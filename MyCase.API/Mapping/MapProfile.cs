using AutoMapper;
using MyCase.API.DTOs;
using MyCase.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCase.API.Mapping
{
    public class MapProfile: Profile
    {
        public MapProfile()
        {
            CreateMap<TvShow, TvShowDto>().ReverseMap();
            CreateMap<EpisodeDto, Episode>().ReverseMap();
            CreateMap<Season, SeasonDto>().ReverseMap();
            CreateMap<ImageDto, Image>().ReverseMap();
        }
    }
}
