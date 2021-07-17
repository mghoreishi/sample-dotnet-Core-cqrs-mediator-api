using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Infrastructures.Data.SqlServer.Queries.ArticleCategoryAggregate.GetArticleCategoryList
{
    public class GetArticleCategoryListQuery : IRequest<List<ArticleCategoryDto>>
    {
    }
}
