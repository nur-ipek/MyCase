using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCase.Core.Models
{
    public class TvShow
    {
        public TvShow()
        {
            Seasons = new Collection<Season>();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }

        public ICollection<Season> Seasons { get; set; }
        public Image Image { get; set; }
        public virtual Guid ImageId { get; set; }

    }
}
