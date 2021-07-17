using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.Core.ApplicationService.Commands.ArticleAggregate.CreateArticle
{
    public class CreateArticleCommand : IRequest<ResponseCreateArticleDto>
    {
        public CreateArticleRequest ArticleRequest { get; set; }
    }
}
