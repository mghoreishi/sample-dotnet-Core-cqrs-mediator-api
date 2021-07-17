using RsjFramework.Entities;
using SampleProject.Core.Domain.ArticelCategoryAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.Core.Domain.ArticleAggregate
{
    public class Article : AuditableEntity<int>
    {
        public string Title { get; private set; }
        public string ShortDescription { get; private set; }
        public string Content { get; private set; }
        public int ArticleCategoryId { get; private set; }
        public ArticleCategory ArticleCategory { get; private set; }

        protected Article()
        {
        }



        private static void Validate(string title, long articleCategoryId)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentNullException();

            if (articleCategoryId == 0)
                throw new ArgumentOutOfRangeException();
        }
        public static Result<Article> Create(string title, string shortDescription, string content, int articleCategoryId)
        {
            return Result.Ok(new Article
            {
                Title = title,
                ShortDescription = shortDescription,
                Content = content,
                ArticleCategoryId = articleCategoryId,
                Created = DateTime.Now
            });
        }

        public void UpdateDetail(string title, string shortDescription, string content, int articleCategoryId)
        {
            Title = title;
            ShortDescription = shortDescription;
            Content = content;
            ArticleCategoryId = articleCategoryId;
        }

    }
}
