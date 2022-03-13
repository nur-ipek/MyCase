using MyCase.Core.Models;
using MyCase.Core.Repositories;
using MyCase.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCase.Service.Services
{
    public class TvShowService: ITvShowService
    {
        private readonly ITvShowRepository _tvShowRepository;
        public TvShowService(ITvShowRepository tvShowRepository)
        {
            _tvShowRepository = tvShowRepository;
        }

        public IEnumerable<TvShow> GetTvShows()
        {
           return _tvShowRepository.GetTvShows();
        }
    }
}
