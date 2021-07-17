using MediatR;
using SampleProject.Core.Domain;
using SampleProject.Core.Domain.ArticelCategoryAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SampleProject.Core.ApplicationService.Commands.ArticleCategoryAggregate
{
    public class CreateArticleCategoryCommandHandler : IRequestHandler<CreateArticleCategoryCommand, ResponseCreateArticleCategoryDto>
    {
        private readonly ISampleProjectDbContext _context;
        public CreateArticleCategoryCommandHandler(ISampleProjectDbContext context)
        {
            _context = context;
        }
        public async Task<ResponseCreateArticleCategoryDto> Handle(CreateArticleCategoryCommand request, CancellationToken cancellationToken)
        {
            var articleCategory = await _context.ArticleCategories.AddAsync(ArticleCategory.Create(title: request.ArticleCategoryRequest.Title).Value);
            await _context.SaveChangesAsync(cancellationToken);
            return new ResponseCreateArticleCategoryDto() { id = articleCategory.Entity.Id };
        }
    }
}
