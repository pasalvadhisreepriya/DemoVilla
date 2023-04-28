using Microsoft.EntityFrameworkCore;
using VillaApi.Models;

namespace VillaApi
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Name = "abc Villa",
                    
                    Occupancy = 10,
                    
                    Sqft = 5000,
                   

                },
                new Villa
                {
                    Id = 2,
                    Name = "def Villa",
                   
                    Occupancy = 9,
                    
                    Sqft = 1000,
                    

                },
                 new Villa
                 {
                     Id = 3,
                     Name = "qwe Villa",

                     Occupancy = 6,

                     Sqft = 500,


                 },
            new Villa
            {
                Id = 4,
                Name = "poi Villa",
               
                Occupancy = 8,
                
                Sqft = 2000,
                


            });
        }
    }
}
