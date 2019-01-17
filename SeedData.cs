using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using PIN.Models;
using PIN;
namespace PIN.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PINContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<PINContext>>()))
            {
               
                if (context.Movie.Any())
                {
                    return;   
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Episode IV: A New Hope",
                        Year = 1977
                        
                    },

                    new Movie
                    {
                        Title = " Episode V: The Empire Strikes Back ",
                        Year = 1980
                       
                    },

                    new Movie
                    {
                        Title = " Episode VI: Return of the Jedi ",
                        Year = 1983
                    },

                    new Movie
                    {
                        Title = "Episode I: The Phantom Menace",
                        Year =1999 
                        
                    },
                    new Movie
                    {
                        Title = "Episode II: Attack of the Clones",
                        Year = 2002

                    },
                     new Movie
                     {
                         Title = "Episode III: Revenge of the Sith",
                         Year = 2005

                     },
                      new Movie
                      {
                          Title = "Episode VII: The Force Awakens",
                          Year = 2015

                      }, new Movie
                      {
                          Title = "Episode VIII: The Last Jedi",
                          Year = 2017

                      },
                      new Movie
                      {
                          Title = "Episode IX",
                          Year = 2017

                      }

                );
                context.SaveChanges();
            }
        }
    }
}