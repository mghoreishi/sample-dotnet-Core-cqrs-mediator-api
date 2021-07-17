using RsjFramework.Entities;
using SampleProject.Core.Domain.ArticleAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.Core.Domain.ArticelCategoryAggregate
{
    public class ArticleCategory : AuditableEntity<int>
    {
        public string Title { get; private set; }
        public ICollection<Article> Articles { get; private set; }


        public static Result<ArticleCategory> Create(string title)
        {
            return Result.Ok(new ArticleCategory
            {
                Title = title
            });
        }

     
    }

}