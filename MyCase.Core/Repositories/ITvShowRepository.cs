using MyCase.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCase.Core.Repositories
{
    //Bu case özelinde client'a sadece 1 model döneceğimden dolayı BaseRepository yapma ihtiyacı duymadım.
    //BaseRepository yapmış olsaydım tüm modeller için ortak kullanılacak metotları ona eklerdim.
    public interface ITvShowRepository
    {
        IEnumerable<TvShow> GetTvShows();
       
    }
}
