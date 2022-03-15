using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyCase.API.DTOs;
using MyCase.Core.Models;
using MyCase.Core.Services;
using MyCase.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCase.API.Controllers
{
    [Route("api/v1")]
    [ApiController]
    public class TvShowController : Controller
    {
        private readonly ITvShowService _tvShowService;
        private readonly IMapper _mapper;
        public TvShowController(ITvShowService tvShowService,IMapper mapper)
        {
            _tvShowService = tvShowService;
            _mapper = mapper;
        }

        //REST kaynaklarla çalışmak için GET, DELETE, POST, PUT gibi HTTP yöntemleri kullanır.
        [HttpGet]
        [Route("TvShows")]
        public IActionResult GetAll()
        {
           var tvShowList= _tvShowService.GetTvShows().ToList();

            return Ok(_mapper.Map<IEnumerable<TvShowDto>>(tvShowList)); //200 durum kodu

        }
    }
}
