using AutoMapper;
using Blog.Entity.DTOs.Articles;
using Blog.Entity.DTOs.Users;
using Blog.Entity.Entities;
using Blog.Entity.Enums;
using Blog.Service.Extensions;
using Blog.Service.Helpers.Images;
using Blog.Web.ResultMessages;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NToastNotify;
using System.Security.Claims;

namespace Blog.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly IMapper mapper;
        private readonly RoleManager<AppRole> roleManager;
        private readonly IToastNotification toastNotification;
        private readonly IImageHelper imageHelper;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly ClaimsPrincipal _user;

        public UserController(UserManager<AppUser> userManager, IMapper mapper, RoleManager<AppRole> roleManager, IToastNotification toastNotification, IHttpContextAccessor httpContextAccessor, IImageHelper imageHelper)
        {
            this.userManager = userManager;
            this.mapper = mapper;
            this.roleManager = roleManager;
            this.toastNotification = toastNotification;
            this.imageHelper = imageHelper;
            _user = httpContextAccessor.HttpContext.User;
        }

        public async Task<IActionResult> Index()
        {
            var users = await userManager.Users.ToListAsync();
            var map = mapper.Map<List<UserDto>>(users);

            foreach (var user in map)
            {
                var findUser = await userManager.FindByIdAsync(user.Id.ToString());
                var role = string.Join("",await userManager.GetRolesAsync(findUser));

                user.Role = role;
            }


            return View(map);
        }


        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var roles = await roleManager.Roles.ToListAsync();
            return View(new UserAddDto { Roles = roles});
        }

        [HttpPost]
        public async Task<IActionResult> Add(UserAddDto userAddDto)
        {
            var map = mapper.Map<AppUser>(userAddDto);
            var roles = await roleManager.Roles.ToListAsync();

            var admin = _user.GetLoggedInEmail();
            var imageUpload = await imageHelper.Upload(userAddDto.FirstName, userAddDto.Photo, ImageType.Post);

            if (ModelState.IsValid)
            {
                map.UserName = userAddDto.Email;
                map.Image = new Image
                {
                    Id = Guid.NewGuid(),
                    FileName = imageUpload.FullName,
                    FileType = userAddDto.Photo.ContentType,
                    CreatedBy = admin
                };
                var result = await userManager.CreateAsync(map, string.IsNullOrEmpty( userAddDto.Password) ? "" : userAddDto.Password);
                
                if (result.Succeeded)
                {
                    var findRole = await roleManager.FindByIdAsync(userAddDto.RoleId.ToString());
                    await userManager.AddToRoleAsync(map,findRole.ToString());

                    toastNotification.AddSuccessToastMessage(Messages.User.Add(userAddDto.FirstName), new ToastrOptions { Title = "Başarılı!" });
                    return RedirectToAction("Index", "User", new { Area = "Admin" });
                }
                else
                {
                    foreach (var errors in result.Errors)
                    {
                        ModelState.AddModelError("", errors.Description);
                    }
                    return View(new UserAddDto { Roles = roles });
                }
            }
            return View(new UserAddDto { Roles = roles });
        }
    }
}
