using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyCase.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCase.Data.Configurations
{
    public class TvShowConfiguration : IEntityTypeConfiguration<TvShow>
    {
        public void Configure(EntityTypeBuilder<TvShow> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.ToTable("TvShows");
        }
    }
}
