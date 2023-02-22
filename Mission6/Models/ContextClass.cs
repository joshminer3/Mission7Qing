using System;
using Microsoft.EntityFrameworkCore;
namespace Mission6.Models
{
	public class ContextClass : DbContext
	{
		//Constructor
		public ContextClass (DbContextOptions<ContextClass> options) : base (options)
		{
			//Leave Blank for now
		}

		public DbSet<MovieForm> Responses { get; set; }

        public DbSet<Category> Categories { get; set; }


        //Seed Data
		protected override void OnModelCreating(ModelBuilder mb)
		{
            //Seed Category ID's and Names
            mb.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Musical"},
                new Category { CategoryID= 2, CategoryName= "Fantasy"},
                new Category { CategoryID = 3, CategoryName = "Drama"},
                new Category { CategoryID = 4, CategoryName = "Action" },
                new Category { CategoryID = 5, CategoryName = "Comedy" },
                new Category { CategoryID = 6, CategoryName = "Horror" },
                new Category { CategoryID = 7, CategoryName = "Sports" },
                new Category { CategoryID = 8, CategoryName = "Romance" }

                );

            //Seed Response entries
            mb.Entity<MovieForm>().HasData(

                new MovieForm
                {
                    AppId = 1,
                    CategoryID = 1,
                    Title = "School of Rock",
                    Year = 2003,
                    Director = "Richard Linklatler",
                    Rating = "PG-13",
                    Edited = true,
                    LentTo = "Josh",
                    Notes = "Great Movie"
                },

                new MovieForm
                {
                    AppId = 2,
                    CategoryID = 2,
                    Title = "Lord of the Rings",
                    Year = 2001,
                    Director = "Peter Jackson",
                    Rating = "PG-13",
                    Edited = true,
                    LentTo = "Josh",
                    Notes = "Fantastic Movie"
                },


                new MovieForm
                {
                    AppId = 3,
                    CategoryID = 3,
                    Title = "Whiplash",
                    Year = 2014,
                    Director = "Damien Chazelle",
                    Rating = "R",
                    Edited = true,
                    LentTo = "Josh",
                    Notes = "Amazing Film"
                }
            );
		}

	}
}

