using MyCase.Core.Models;
using MyCase.Core.Repositories;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCase.Data.JsonRepository
{
    public class TvShowRepositoryJson: ITvShowRepository
    {
        private readonly string _path = $"C:\\Users\\nuryilmaz\\source\\repos\\MyCase\\MyCase.Data\\Context\\JsonContext\\tvShowsContextJson.json";
        public IEnumerable<TvShow> GetTvShows()
        {
            string jsonFromFile;
            using (var reader = new StreamReader(_path))
            {
                jsonFromFile = reader.ReadToEnd(); 
            }
         var tvShowFromJson = JsonConvert.DeserializeObject<IEnumerable<TvShow>>(jsonFromFile);

            return tvShowFromJson;
        }
    }
}
