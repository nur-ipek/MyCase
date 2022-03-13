using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCase.Core.Models
{
    public class Season
    {
        public Season()
        {
            Episodes = new Collection<Episode>();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }
        public virtual Guid TvShowId { get; set; }
        public virtual TvShow TvShow { get; set; }
        public ICollection<Episode> Episodes { get; set; }
    }
}
