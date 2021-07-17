using Microsoft.AspNetCore.Mvc;
using MyBlog.Infrastructures.Data.SqlServer.Queries.ArticleAggregate.GetArticleList;
using MyBlog.Infrastructures.Data.SqlServer.Queries.ArticleCategoryAggregate.GetArticleCategoryList;
using SampleProject.Core.ApplicationService.Commands.ArticleCategoryAggregate;
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
    public class ArticleCategoryController : BaseController
    {
      
        [HttpGet]
        [ProducesResponseType(typeof(List<ArticleCategoryDto>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetArticleCategories()
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var result = await Mediator.Send(new GetArticleCategoryListQuery());

            return Ok(result);
        }


        
        [HttpPost]
        [ProducesResponseType(typeof(ResponseCreateArticleCategoryDto), (int)HttpStatusCode.Created)]
        public async Task<IActionResult> CreateArticleCategory([FromBody] ArticleCategoryModel model)
        {
            var result = await Mediator.Send(new CreateArticleCategoryCommand()
            {
                ArticleCategoryRequest = new CreateArticleCategoryRequest()
                {
                    Title = model.Title
                }
            });

            return Ok(result);
        }
    }
}
