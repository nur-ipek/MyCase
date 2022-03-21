using Microsoft.EntityFrameworkCore;
using MyCase.Core.Models;
using MyCase.Data.Configurations;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCase.Data.Context
{
    public class TvShowsContext: DbContext
    {
        public TvShowsContext(DbContextOptions<TvShowsContext> options): base(options)
        {

        }
        public DbSet<TvShow> TvShows { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<Episode> Episodes { get; set; }
        public DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TvShowConfiguration());
            modelBuilder.ApplyConfiguration(new EpisodeConfiguration());
            modelBuilder.ApplyConfiguration(new SeasonConfiguration());
            modelBuilder.ApplyConfiguration(new ImageConfiguration());

            modelBuilder.Entity<Image>().HasData(new Image
            {
                Id = Guid.Parse("4c1f66c7-69b0-439b-b34d-8ebfddf5942c"),
                Medium = "http://static.tvmaze.com/uploads/images/medium_portrait/0/1.jpg",
                Original = "http://static.tvmaze.com/uploads/images/original_untouched/0/1.jpg"
            });

            modelBuilder.Entity<TvShow>().HasData(new TvShow
            {
                Id = Guid.Parse("1282d141-674d-43b4-89cf-e87c814f0021"),
                Name = "Hayaller ve Hayatlar",
                ImageId = Guid.Parse("4c1f66c7-69b0-439b-b34d-8ebfddf5942c")
            });


           modelBuilder.Entity<Season>().HasData(new Season
            {
                Id = Guid.Parse("88f9b49e-f21e-42af-93ed-0e4746b6eb3f"),
                Name = "Sezon 1",
                Summary = "Hayallerinin peşinde koşarken hayata yakalananların hikayesini anlatan...",
                TvShowId = Guid.Parse("1282d141-674d-43b4-89cf-e87c814f0021")
            },
            new Season
            {
                Id = Guid.Parse("1b750d2a-9594-4a34-be51-c1a5ced11d56"),
                Name = "Sezon 2",
                Summary = "Hayallerinin peşinde koşarken hayata yakalananların hikayesini anlatan v2...",
                TvShowId = Guid.Parse("1282d141-674d-43b4-89cf-e87c814f0021")
            });

            modelBuilder.Entity<Episode>().HasData(new Episode
            {
                Id = Guid.Parse("3e4576c7-09df-4646-9c96-cdb210bb0741"),
                Rank= "1.Bölüm",
                Name = "Kalbimizi Kıracaklar",
                Summary = "Yakın arkadaşlar Dicle,Güneş vs. için yenibir gün.. ",
                SeasonId = Guid.Parse("88f9b49e-f21e-42af-93ed-0e4746b6eb3f")
            },
            new Episode
            {
                Id = Guid.Parse("6c91df7f-363a-46ac-9364-543a2e00e743"),
                Rank = "1.Bölüm",
                Name = "Tehlikeli Sular",
                Summary = "Güneşin işteki ilk günü.. ",
                SeasonId = Guid.Parse("1b750d2a-9594-4a34-be51-c1a5ced11d56")
            }
            );

            base.OnModelCreating(modelBuilder);
        } 
    }
}
