using MediatR;
using Microsoft.EntityFrameworkCore;
using SampleProject.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyBlog.Infrastructures.Data.SqlServer.Queries.ArticleCategoryAggregate.GetArticleCategoryList
{
    public class GetArticleCategoryListQueryHandler : IRequestHandler<GetArticleCategoryListQuery, List<ArticleCategoryDto>>

    {
        private readonly ISampleProjectDbContext _context;
        public GetArticleCategoryListQueryHandler(ISampleProjectDbContext context)
        {
            _context = context;
        }
        public async Task<List<ArticleCategoryDto>> Handle(GetArticleCategoryListQuery request, CancellationToken cancellationToken)
        {
            return await _context.ArticleCategories
                .Include(o => o.Articles)
                .Select(o => new ArticleCategoryDto
                {
                    Id = o.Id,
                    Title = o.Title,
                    ArticleCount = o.Articles.Count

                })
               .AsNoTracking()
               .ToListAsync();
        }


    }
}
