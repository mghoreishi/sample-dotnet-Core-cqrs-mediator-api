using Microsoft.AspNetCore.Mvc;
using MyBlog.Infrastructures.Data.SqlServer.Queries.ArticleAggregate.GetArticleList;
using SampleProject.Core.ApplicationService.Commands.ArticleAggregate.CreateArticle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ArticleController : BaseController
    {
     
        [HttpGet]
        [ProducesResponseType(typeof(List<ArticleDto>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetArticles()
        {
            if (!ModelState.IsValid)
                return BadRequest();


            var result = await Mediator.Send(new GetArticlesQuery());

            return Ok(result);
        }

      
        [HttpPost]
        [ProducesResponseType(typeof(ResponseCreateArticleDto), (int)HttpStatusCode.Created)]
        public async Task<IActionResult> CreateArticle([FromBody] CreateArticleRequest model)
        {
            var result = await Mediator.Send(new CreateArticleCommand()
            {
                ArticleRequest=new CreateArticleRequest()
                {
                    Title = model.Title,
                    Content = model.Content,
                    ShortDescription = model.ShortDescription,
                    ArticleCategoryId = model.ArticleCategoryId
                }

            });

            return Ok(result);
        }
    }
}
