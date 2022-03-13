using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCase.Core.Models
{
    public class Episode
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }
        public virtual Guid SeasonId { get; set; }
        public virtual Season Season { get; set; }
    }
}
