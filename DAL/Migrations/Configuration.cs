namespace DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.Models.NewsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.Models.NewsContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            for (int i = 1; i <= 10; i++)
            {
                context.Users.AddOrUpdate(new Models.User
                {
                    Name = Guid.NewGuid().ToString().Substring(0, 15),
                    Uname = "User-" + i,
                    Password = Guid.NewGuid().ToString().Substring(0, 10),
                    Type = "General"
                });
            }
            Random random= new Random();
            
            for (int i = 1; i <= 20; i++)
            {
                context.Newses.AddOrUpdate(new Models.News
                {
                    Id = i,
                    Title= Guid.NewGuid().ToString().Substring(0, 15),
                    Description= Guid.NewGuid().ToString(),
                    Date= DateTime.Now,
                    NewsBy = "User-" + random.Next(1, 11),

                });
            }
            for (int i = 1; i <= 100; i++)
            {
                context.Comments.AddOrUpdate(new Models.Comment
                {
                    Id = i,
                    CommentText = Guid.NewGuid().ToString().Substring(0, 15),
                    NewsId = random.Next(1, 21),
                    Time = DateTime.Now,
                    CommentBy = "User-" + random.Next(1, 11),

                });
            }

        }
            
        }
    }
