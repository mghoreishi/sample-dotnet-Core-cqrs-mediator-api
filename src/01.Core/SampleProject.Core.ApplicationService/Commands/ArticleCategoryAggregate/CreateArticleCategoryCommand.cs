using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.Core.ApplicationService.Commands.ArticleCategoryAggregate
{
    public class CreateArticleCategoryCommand : IRequest<ResponseCreateArticleCategoryDto>
    {
        public CreateArticleCategoryRequest ArticleCategoryRequest { get; set; }
    }
}
