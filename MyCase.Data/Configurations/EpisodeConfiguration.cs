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
    public class EpisodeConfiguration : IEntityTypeConfiguration<Episode>
    {
        public void Configure(EntityTypeBuilder<Episode> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.ToTable("Episodes");
        }
    }
}
