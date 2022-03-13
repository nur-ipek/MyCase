using MyCase.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCase.Core.Services
{
    public interface ITvShowService
    {
        IEnumerable<TvShow> GetTvShows();
    }
}
