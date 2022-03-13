using Microsoft.EntityFrameworkCore;
using MyCase.Core.Models;
using MyCase.Core.Repositories;
using MyCase.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCase.Data.Repositories
{
    public class TvShowRepository : ITvShowRepository
    {
        public readonly DbContext _context;
        public readonly DbSet<TvShow> _dbset;
        public TvShowRepository(TvShowsContext tvShowsContext)
        {
            _context = tvShowsContext;
            _dbset = tvShowsContext.Set<TvShow>();
        }
        public IEnumerable<TvShow> GetTvShows()
        {
            return _dbset.Include(c => c.Seasons).ThenInclude(a=>a.Episodes)
                .Include(e => e.Image)
                .ToList();
        }
    }
}
