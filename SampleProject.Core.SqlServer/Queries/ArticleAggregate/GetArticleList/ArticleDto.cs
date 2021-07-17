using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Infrastructures.Data.SqlServer.Queries.ArticleAggregate.GetArticleList
{
   public class ArticleDto
    {
        public long Id { get; set; }
        public string Title { get;  set; }
        public string ShortDescription { get;  set; }
        public string Image { get;  set; }
        public long ArticleCategoryId { get;  set; }
    }
}
