using MyCase.Core.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace MyCase.API.DTOs
{
    public class SeasonDto
    {
        public string Name { get; set; }
        public string Summary { get; set; }
        public ICollection<EpisodeDto> Episodes { get; set; }
    }
}
