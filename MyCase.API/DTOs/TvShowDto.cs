using MyCase.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCase.API.DTOs
{
    public class TvShowDto
    {
        public string Name { get; set; }
        public ICollection<SeasonDto> Seasons { get; set; }
        public ImageDto Image { get; set; }
    }
}
