using Blog.Entity.DTOs.Articles;
using Blog.Entity.DTOs.Categories;
using Blog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Service.Services.Abstractions
{
    public interface ICategoryService
    {
        public Task<List<CategoryDto>> GetAllCategoriesNonDeleted();

        Task CreateCategoryAsync(CategoryAddDto categoryAddDto);

        Task<Category> GetCategoryById(Guid id);

        Task<string> UpdateCategoryAsync(CategoryUpdateDto categoryUpdateDto);

        public Task SafeDeleteCategoryAsync(Guid categoryId);
    }
}
