using AcademyLover.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademyLover.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class ArticlesController : Controller
    {
        private readonly IArticleAppService _articleService;

        public ArticlesController(IArticleAppService articleAppService)
        {
            _articleService = articleAppService;
        }
    }
}
