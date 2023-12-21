using AutoMapper;
using Blog.Entity.DTOs.Articles;
using Blog.Entity.DTOs.Categories;
using Blog.Entity.Entities;
using Blog.Service.Extensions;
using Blog.Service.Services.Abstractions;
using Blog.Service.Services.Concrete;
using Blog.Web.ResultMessages;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using System.ComponentModel.DataAnnotations;

namespace Blog.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService categoryService;
        private readonly IValidator<Category> validator;
        private readonly IMapper mapper;
        private readonly IToastNotification toastNotification;

        public CategoryController(ICategoryService categoryService, IValidator<Category> validator, IMapper mapper, IToastNotification toastNotification)
        {
            this.categoryService = categoryService;
            this.validator = validator;
            this.mapper = mapper;
            this.toastNotification = toastNotification;
        }



        public async Task<IActionResult> Index()
        {
            var categories = await categoryService.GetAllCategoriesNonDeleted();
            return View(categories);
        }


        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(CategoryAddDto categoryAddDto)
        {
            var map = mapper.Map<Category>(categoryAddDto);
            var result = await validator.ValidateAsync(map);

            if (result.IsValid)
            {
                await categoryService.CreateCategoryAsync(categoryAddDto);
                toastNotification.AddSuccessToastMessage(Messages.Article.Add(categoryAddDto.Name), new ToastrOptions { Title = "Başarılı!" });
                return RedirectToAction("Index", "Category", new { Area = "Admin" });
            }
           
                result.AddToModelState(this.ModelState);
                return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddWithAjax([FromBody] CategoryAddDto categoryAddDto)
        {
            var map = mapper.Map<Category>(categoryAddDto);
            var result = await validator.ValidateAsync(map);

            if (result.IsValid)
            {
                await categoryService.CreateCategoryAsync(categoryAddDto);
                toastNotification.AddSuccessToastMessage(Messages.Article.Add(categoryAddDto.Name), new ToastrOptions { Title = "Başarılı!" });
                return Json(new { success = true, message = Messages.Article.Add(categoryAddDto.Name) });
            }
            else
            {
                toastNotification.AddErrorToastMessage(result.Errors.First().ErrorMessage, new ToastrOptions { Title = "Başarısız!" });
                return Json(new {result.Errors.First().ErrorMessage });
            }
        }

        [HttpGet]
        public async Task<IActionResult> Update(Guid categoryId)
        {
            var category = await categoryService.GetCategoryById(categoryId);
            var map = mapper.Map<Category, CategoryUpdateDto>(category);

            return View(map);
        }

        [HttpPost]
        public async Task<IActionResult> Update(CategoryUpdateDto categoryUpdateDto)
        {
            var map = mapper.Map<Category>(categoryUpdateDto);
            var result = await validator.ValidateAsync(map);

            if (result.IsValid)
            {
                var name = await categoryService.UpdateCategoryAsync(categoryUpdateDto);
                toastNotification.AddSuccessToastMessage(Messages.Article.Update(name), new ToastrOptions { Title = "Başarılı!" });
                return RedirectToAction("Index", "Category", new { Area = "Admin" });
            }

            result.AddToModelState(this.ModelState);
            return View();
        }

        public async Task<IActionResult> Delete(Guid categoryId)
        {
            var category = await categoryService.GetCategoryById(categoryId);
            await categoryService.SafeDeleteCategoryAsync(categoryId);

            toastNotification.AddSuccessToastMessage(Messages.Category.Delete(category.Name), new ToastrOptions { Title = "Başarılı!" });

            return RedirectToAction("Index", "Category", new { Area = "Admin" });
        }

    }
}
