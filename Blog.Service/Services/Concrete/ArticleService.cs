using AutoMapper;
using Blog.Data.UnitOfWorks;
using Blog.Entity.DTOs.Articles;
using Blog.Entity.Entities;
using Blog.Service.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Service.Services.Concrete
{
    public class ArticleService : IArticleService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public ArticleService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task CreateArticleAsync(ArticleAddDto articleAddDto)
        {
            var userId = Guid.Parse("372F18FE-FE3F-4826-A47E-8E77260F684B");
            var imageId = Guid.Parse("214BCD11-2794-4A88-96B5-53580337C0AE");
            var article = new Article(articleAddDto.Title, articleAddDto.Content, userId, articleAddDto.CategoryId, imageId);
            

            await unitOfWork.GetRepository<Article>().AddAsync(article);
            await unitOfWork.SaveAsync();
        }

        public async Task<List<ArticleDto>> GetAllArticleWithCategoryNonDeletedAsync()
        {
            var articles = await unitOfWork.GetRepository<Article>().GetAllAsync(x=>!x.IsDeleted, x=>x.Category);
            var map = mapper.Map<List<ArticleDto>>(articles);

            return map;
        }

        public async Task<ArticleDto> GetArticleWithCategoryNonDeletedAsync(Guid articleId)
        {
            var article = await unitOfWork.GetRepository<Article>().GetAsync(x => !x.IsDeleted && x.Id == articleId, x => x.Category);
            var map = mapper.Map<ArticleDto>(article);

            return map;
        }

        public async Task UpdateArticleAsync(ArticleUpdateDto articleUpdateDto)
        {
            var article = await unitOfWork.GetRepository<Article>().GetAsync(x => !x.IsDeleted && x.Id == articleUpdateDto.Id, x=>x.Category);

            article.Title = articleUpdateDto.Title;
            article.Content = articleUpdateDto.Content;
            article.CategoryId = articleUpdateDto.CategoryId;


            await unitOfWork.GetRepository<Article>().UpdateAsync(article);

            await unitOfWork.SaveAsync();
        }

        public async Task SafeDeleteArticleAsync(Guid articleId)
        {
           var article = await unitOfWork.GetRepository<Article>().GetByGuidAsync(articleId);

            article.IsDeleted = true;
            article.DeletedDate = DateTime.Now;

            await unitOfWork.GetRepository<Article>().UpdateAsync(article);
            await unitOfWork.SaveAsync();

        }
    }
}
