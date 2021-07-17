using MediatR;
using Microsoft.EntityFrameworkCore;
using SampleProject.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyBlog.Infrastructures.Data.SqlServer.Queries.ArticleAggregate.GetArticleList
{
    public class GetArticleListQueryHandler : IRequestHandler<GetArticlesQuery, List<ArticleDto>>
    {
        private readonly ISampleProjectDbContext _context;
        public GetArticleListQueryHandler(ISampleProjectDbContext context)
        {
            _context = context;
        }
        public async Task<List<ArticleDto>> Handle(GetArticlesQuery request, CancellationToken cancellationToken)
        {
            return await _context.Articles.Select(o => new ArticleDto
            {
                Id = o.Id,
                Title = o.Title,
                ShortDescription = o.ShortDescription,
                ArticleCategoryId = o.ArticleCategoryId
            })
            .AsNoTracking()
             .ToListAsync();
        }

    }
}
