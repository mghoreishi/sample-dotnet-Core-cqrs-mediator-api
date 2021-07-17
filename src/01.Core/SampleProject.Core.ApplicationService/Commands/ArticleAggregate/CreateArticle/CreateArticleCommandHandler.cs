using MediatR;
using SampleProject.Core.Domain;
using SampleProject.Core.Domain.ArticleAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SampleProject.Core.ApplicationService.Commands.ArticleAggregate.CreateArticle
{
    public class CreateArticleCommandHandler : IRequestHandler<CreateArticleCommand, ResponseCreateArticleDto>
    {
        private readonly ISampleProjectDbContext _context;
        public CreateArticleCommandHandler(ISampleProjectDbContext context)
        {
            this._context = context;
        }
        public async Task<ResponseCreateArticleDto> Handle(CreateArticleCommand request, CancellationToken cancellationToken)
        {
            var article = await _context.Articles.AddAsync(Article.Create(title: request.ArticleRequest.Title, shortDescription: request.ArticleRequest.ShortDescription,
                content: request.ArticleRequest.Content, articleCategoryId: request.ArticleRequest.ArticleCategoryId).Value);
            await _context.SaveChangesAsync(cancellationToken);

            return new ResponseCreateArticleDto { Id = article.Entity.Id };
        }


    }
}
