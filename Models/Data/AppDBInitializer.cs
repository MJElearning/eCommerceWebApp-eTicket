using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket.Models.Data
{
    public class AppDBInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDBContext>();
                context.Database.EnsureCreated();

                if (!context.Screens.Any())
                {
                    context.Screens.AddRange(new List<Screen>() {
                    new Screen()
                    {
                        Name="Screen 1",
                        Description="First Screen",
                        Logo="http://dotnethow.net/images/cinemas/cinema-1.jpeg"
                    },
                    new Screen()
                    {
                        Name="Screen 2",
                        Description="Second Screen",
                        Logo="http://dotnethow.net/images/cinemas/cinema-2.jpeg"
                    },
                    new Screen()
                    {
                        Name="Screen 3",
                        Description="Third Screen",
                        Logo="http://dotnethow.net/images/cinemas/cinema-3.jpeg"
                    },
                    new Screen()
                    {
                        Name="Screen 4",
                        Description="Fourth Screen",
                        Logo="http://dotnethow.net/images/cinemas/cinema-4.jpeg"
                    },
                    new Screen()
                    {
                        Name="Screen 5",
                        Description="Fifth Screen",
                        Logo="http://dotnethow.net/images/cinemas/cinema-5.jpeg"
                    }
                    }
                    );
                    context.SaveChanges();
                }





                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>() {
                    new Actor()
                    {
                        ActorName="Actor 1",
                        ActorBio="Hollywood actor",
                        ProfileURL="http://dotnethow.net/images/actors/actor-1.jpeg"
                    },
                    new Actor()
                    {
                        ActorName="Actor 2",
                        ActorBio="Hollywood actor",
                        ProfileURL="http://dotnethow.net/images/actors/actor-2.jpeg"
                    },
                    new Actor()
                    {
                        ActorName="Actor 3",
                        ActorBio="Hollywood actor",
                        ProfileURL="http://dotnethow.net/images/actors/actor-3.jpeg"
                    },
                    new Actor()
                    {
                        ActorName="Actor 4",
                        ActorBio="Hollywood actor",
                        ProfileURL="http://dotnethow.net/images/actors/actor-4.jpeg"
                    },
                    new Actor()
                    {
                        ActorName="Actor 5",
                        ActorBio="Hollywood actor",
                        ProfileURL="http://dotnethow.net/images/actors/actor-5.jpeg"
                    }
                    }
                    );
                    context.SaveChanges();
                }


                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>() {
                    new Producer()
                    {
                        ProducerName="Producer 1",
                        ProducerBio="Hollywood Producer",
                        ProfileURL="http://dotnethow.net/images/producers/producer-1.jpeg"
                    },
                    new Producer()
                    {
                        ProducerName="Producer 2",
                        ProducerBio="Hollywood Producer",
                        ProfileURL="http://dotnethow.net/images/producers/producer-2.jpeg"
                    },
                    new Producer()
                    {
                        ProducerName="Producer 3",
                        ProducerBio="Hollywood Producer",
                        ProfileURL="http://dotnethow.net/images/producers/producer-3.jpeg"
                    },
                    new Producer()
                    {
                        ProducerName="Producer 4",
                        ProducerBio="Hollywood Producer",
                        ProfileURL="http://dotnethow.net/images/producers/producer-4.jpeg"
                    },
                    new Producer()
                    {
                        ProducerName="Producer 5",
                        ProducerBio="Hollywood Producer",
                        ProfileURL="http://dotnethow.net/images/producers/producer-5.jpeg"
                    }
                    }
                    );
                    context.SaveChanges();
                }


                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>() {
                    new Movie()
                    {
                       MovieName="Movie 1",
                       MovieDescription="Desciption 1",
                       ImageURL="http://dotnethow.net/images/movies/movie-1.jpeg",
                       StartDate=DateTime.Now.AddDays(-10),
                       EndDate=DateTime.Now.AddDays(20),
                       ScreenId=1,
                       ProducerId=1,
                       Category=Enums.MovieCategory.Adventure,
                       TicketPrice=10.25
                    },
                    new Movie()
                    {
                       MovieName="Movie 2",
                       MovieDescription="Desciption 2",
                       ImageURL="http://dotnethow.net/images/movies/movie-2.jpeg",
                       StartDate=DateTime.Now.AddDays(-10),
                       EndDate=DateTime.Now.AddDays(20),
                       ScreenId=1,
                       ProducerId=2,
                       Category=Enums.MovieCategory.Adventure,
                       TicketPrice=10.50
                    },
                    new Movie()
                    {
                       MovieName="Movie 3",
                       MovieDescription="Desciption 3",
                       ImageURL="http://dotnethow.net/images/movies/movie-3.jpeg",
                       StartDate=DateTime.Now.AddDays(-2),
                       EndDate=DateTime.Now.AddDays(30),
                       ScreenId=2,
                       ProducerId=3,
                       Category=Enums.MovieCategory.Comedy,
                       TicketPrice=5
                    },
                    new Movie()
                    {
                       MovieName="Movie 4",
                       MovieDescription="Desciption 4",
                       ImageURL="http://dotnethow.net/images/movies/movie-4.jpeg",
                       StartDate=DateTime.Now.AddDays(-5),
                       EndDate=DateTime.Now.AddDays(25),
                       ScreenId=3,
                       ProducerId=1,
                       Category=Enums.MovieCategory.Drama,
                       TicketPrice=7.50
                    }
                    }
                    );
                    context.SaveChanges();
                }

                if (!context.Actor_Movies.Any())
                {
                    context.Actor_Movies.AddRange(new List<Actor_Movie>() {
                    new Actor_Movie()
                    {
                       ActorId=2,
                       MovieId=3
                    },
                    new Actor_Movie()
                    {
                       ActorId=1,
                       MovieId=4
                    },
                    new Actor_Movie()
                    {
                       ActorId=3,
                       MovieId=5
                    }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
