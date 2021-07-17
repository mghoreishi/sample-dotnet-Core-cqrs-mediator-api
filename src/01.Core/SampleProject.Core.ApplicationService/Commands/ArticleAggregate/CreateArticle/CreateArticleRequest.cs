using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.Core.ApplicationService.Commands.ArticleAggregate.CreateArticle
{
    public class CreateArticleRequest
    {
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Content { get; set; }
        public int ArticleCategoryId { get; set; }
    }
}
