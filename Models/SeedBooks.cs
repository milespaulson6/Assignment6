using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    public class SeedBooks
    {
        //this ensures the database is populated with a migration
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            LetriniaDbContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<LetriniaDbContext>();

            if (context.Database.GetPendingMigrations().Any()){
                context.Database.Migrate();
            }
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    //these are the list of products that will be outputted.
                    new Product
                    {
                        Title = "Les Miserables",
                        AuthorFirst = "Victor",
                        AuthorMiddle = "",
                        AuthorLast = "Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        Price = 9.95,
                        PageLength = 1488
                    },
                    new Product
                    {
                        Title = "Team Of Rivals",
                        AuthorFirst = "Doris",
                        AuthorMiddle = "Kearns",
                        AuthorLast = "Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 14.58,
                        PageLength = 944
                    },
                    new Product
                    {
                        Title = "The Snowball",
                        AuthorFirst = "Alice",
                        AuthorMiddle = "",
                        AuthorLast = "Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0552284611",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 21.54,
                        PageLength = 832
                    },
                    new Product
                    {
                        Title = "American Ulysses",
                        AuthorFirst = "Ronald",
                        AuthorMiddle = "C.",
                        AuthorLast = "White",
                        Publisher = "Random House",
                        ISBN = "978-0812981254",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 11.61,
                        PageLength = 864
                    },
                    new Product
                    {
                        Title = "Unbroken",
                        AuthorFirst = "Laura",
                        AuthorMiddle = "",
                        AuthorLast = "Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 13.33,
                        PageLength = 528
                    },
                    new Product
                    {
                        Title = "The Great Train Robbery",
                        AuthorFirst = "Michael",
                        AuthorMiddle = "",
                        AuthorLast = "Crichton",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        Classification = "Fiction",
                        Category = "Historical Fiction",
                        Price = 15.95,
                        PageLength = 288
                    },
                    new Product
                    {
                        Title = "Deep Work",
                        AuthorFirst = "Cal",
                        AuthorMiddle = "",
                        AuthorLast = "Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 14.99,
                        PageLength = 304
                    },
                    new Product
                    {
                        Title = "It's Your Ship",
                        AuthorFirst = "Michael",
                        AuthorMiddle = "",
                        AuthorLast = "Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 21.66,
                        PageLength = 240
                    },
                    new Product
                    {
                        Title = "The Virgin Way",
                        AuthorFirst = "Richard",
                        AuthorMiddle = "",
                        AuthorLast = "Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        Classification = "Non-Fiction",
                        Category = "Business",
                        Price = 29.16,
                        PageLength = 400
                    },
                    new Product
                    {
                        Title = "Sycamore Row",
                        AuthorFirst = "John",
                        AuthorMiddle = "",
                        AuthorLast = "Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        Classification = "Fiction",
                        Category = "Thrillers",
                        Price = 15.03,
                        PageLength = 642
                    },
                    
                    new Product
                    {
                        Title = "Book of Mormon",
                        AuthorFirst = "Joseph",
                        AuthorMiddle = "",
                        AuthorLast = "Smith",
                        Publisher = "E.B Grandin",
                        ISBN = "978-0553393613",
                        Classification = "Non-Fiction",
                        Category = "Religion",
                        Price = 0.00,
                        PageLength = 531

                    },
                    new Product
                    {
                        Title = "The Great Gatsby",
                        AuthorFirst = "F",
                        AuthorMiddle = "Scott",
                        AuthorLast = "Fitzgerald",
                        Publisher = "Charles Scribner Sons",
                        ISBN = "978-0553393603",
                        Classification = "Fiction",
                        Category = "Tragedy",
                        Price = 14.20,
                        PageLength = 200

                    },
                    new Product
                    {
                        Title = "Can't Hurt Me",
                        AuthorFirst = "David",
                        AuthorMiddle = "",
                        AuthorLast = "Goggins",
                        Publisher = "Lioncrest",
                        ISBN = "978-0553393732",
                        Classification = "Non-Fiction",
                        Category = "Motivational",
                        Price = 19.99,
                        PageLength = 364
                    }



                
                    ) ;
                context.SaveChanges();
            }
       
        }
    }
}
