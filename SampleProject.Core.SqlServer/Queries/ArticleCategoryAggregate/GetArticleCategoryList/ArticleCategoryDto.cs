using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Infrastructures.Data.SqlServer.Queries.ArticleCategoryAggregate.GetArticleCategoryList
{
   public class ArticleCategoryDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ArticleCount { get; set; }
    }
}
