using Blog.Entity.DTOs.Articles;
using Blog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Service.Services.Abstractions
{
    public interface IArticleService
    {
        public Task<List<ArticleDto>> GetAllArticleWithCategoryNonDeletedAsync();

        public Task CreateArticleAsync(ArticleAddDto articleAddDto);

        public Task<ArticleDto> GetArticleWithCategoryNonDeletedAsync(Guid articleId);

        public Task UpdateArticleAsync(ArticleUpdateDto articleUpdateDto);

        public Task SafeDeleteArticleAsync(Guid articleId);

    }
}
