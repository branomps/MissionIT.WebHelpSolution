using Microsoft.EntityFrameworkCore;
using MissionIT.WebHelpCore.Models.HelpClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MissionIT.WebHelpCore.Data
{
    public class HelpDbContext : DbContext
    {
        public HelpDbContext(DbContextOptions<HelpDbContext> options)
           : base(options)
        {

        }

        public DbSet<Section> Sections { get; set; }
        public DbSet<Article> Articles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Section>().ToTable("tblSections").HasData
                (
                    new Section
                    {
                        SectionID = 1,
                        SectionName = "How to use Help"
                    },
                    new Section
                    {
                        SectionID = 2,
                        SectionName = "Introduction"
                    },
                    new Section
                    {
                        SectionID = 3,
                        SectionName = "Time Line"
                    },
                    new Section
                    {
                        SectionID = 4,
                        SectionName = "Customer Service"
                    },
                    new Section
                    {
                        SectionID = 5,
                        SectionName = "My Favourites"
                    },
                    new Section
                    {
                        SectionID = 6,
                        SectionName = "User Diary"
                    },
                    new Section
                    {
                        SectionID = 7,
                        SectionName = "Audit Trial"
                    },
                    new Section
                    {
                        SectionID = 8,
                        SectionName = "Quick Change"
                    },
                    new Section
                    {
                        SectionID = 9,
                        SectionName = "Jobs"
                    },
                    new Section
                    {
                        SectionID = 10,
                        SectionName = "Add New"
                    },
                    new Section
                    {
                        SectionID = 11,
                        SectionName = "Lists"
                    },
                    new Section
                    {
                        SectionID = 12,
                        SectionName = "Venue"
                    },
                    new Section
                    {
                        SectionID = 13,
                        SectionName = "Route"
                    },
                    new Section
                    {
                        SectionID = 14,
                        SectionName = "Exception"
                    },
                    new Section
                    {
                        SectionID = 15,
                        SectionName = "Passenger"
                    },
                    new Section
                    {
                        SectionID = 16,
                        SectionName = "Driver"
                    },
                    new Section
                    {
                        SectionID = 17,
                        SectionName = "Attendent"
                    },
                    new Section
                    {
                        SectionID = 18,
                        SectionName = "Vehicle"
                    },
                    new Section
                    {
                        SectionID = 19,
                        SectionName = "Provider"
                    },
                    new Section
                    {
                        SectionID = 20,
                        SectionName = "Work Shop"
                    },
                    new Section
                    {
                        SectionID = 21,
                        SectionName = "Scheduling"
                    },
                    new Section
                    {
                        SectionID = 22,
                        SectionName = "All DBS Application"
                    },
                    new Section
                    {
                        SectionID = 23,
                        SectionName = "Messaging"
                    },
                    new Section
                    {
                        SectionID = 24,
                        SectionName = "Accounts"
                    },
                    new Section
                    {
                        SectionID = 25,
                        SectionName = "Documents"
                    },
                    new Section
                    {
                        SectionID = 26,
                        SectionName = "Utilities"
                    }
                );

            modelBuilder.Entity<Article>().ToTable("tblArticles").HasData
                (
                        
                    new Article
                    {
                        ArticleID = 1,
                        ArticleName = "Menu",
                        ArticleDescription = "werwwwwwwwwwwwwwwwwwwwwwwwwewrwerwerwerwe",
                        ArticleImageUrl = "010001.jpg",
                        SectionID = 1,
                    },
                    new Article
                    {
                        ArticleID = 2,
                        ArticleName = "Routes",
                        ArticleDescription = "werwwwwwwwwwwwwwwwwwwwwwwwwewrwerwerwerwe",
                        ArticleImageUrl = "010002.jpg",
                        SectionID = 2
                    },
                    new Article
                    {
                        ArticleID = 3,
                        ArticleName = "Drivers",
                        ArticleDescription = "werwwwwwwwwwwwwwwwwwwwwwwwwewrwerwerwerwe",
                        ArticleImageUrl = "010003.jpg",
                        SectionID = 2
                    },
                    new Article
                    {
                        ArticleID = 4,
                        ArticleName = "Vehicles",
                        ArticleDescription = "wssssssssssssssssssssssssssssssssssss",
                        ArticleImageUrl = "020004.jpg",
                        SectionID = 3
                    },
                    new Article
                    {
                        ArticleID = 5,
                        ArticleName = "Drivers",
                        ArticleDescription = "eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee",
                        ArticleImageUrl = "020005.jpg",
                        SectionID = 3
                    },
                    new Article
                    {
                        ArticleID = 6,
                        ArticleName = "Audit Trial",
                        ArticleDescription = "werwwwwwwwwwwwwwwwwwwwwwwwwewrwerwerwerwe",
                        ArticleImageUrl = "050006.jpg",
                        SectionID = 4
                    }
                );
        }
    }
}
