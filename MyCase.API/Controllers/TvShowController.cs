using Microsoft.AspNetCore.Mvc;
using MyCase.Core.Models;
using MyCase.Core.Services;
using MyCase.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCase.API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class TvShowController : Controller
    {
        private readonly ITvShowService _tvShowService;
        public TvShowController(ITvShowService tvShowService)
        {
            _tvShowService = tvShowService;
        }

        [HttpGet]
        public IEnumerable<TvShow> GetAll()
        {
           var a= _tvShowService.GetTvShows();
            return a.ToList();
        }
    }
}
