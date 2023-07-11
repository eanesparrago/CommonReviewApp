using CommonReviewApp.Data;
using CommonReviewApp.Models;

namespace ThingReviewApp
{
    public class Seed
    {
        private readonly DataContext dataContext;
        public Seed(DataContext context)
        {
            this.dataContext = context;
        }
        public void SeedDataContext()
        {
            if (!dataContext.ThingOwners.Any())
            {
                var pokemonOwners = new List<ThingOwner>()
                {
                    new ThingOwner()
                    {
                        Thing = new Thing()
                        {
                            Name = "Pikachu",
                            CreatedDate = new DateTime(1903,1,1),
                            ThingCategories = new List<ThingCategory>()
                            {
                                new ThingCategory { Category = new Category() { Name = "Electric"}}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title="Pikachu",Text = "Pickahu is the best pokemon, because it is electric", Rating = 5,
                                Reviewer = new Reviewer(){ Name = "Teddy" } },
                                new Review { Title="Pikachu", Text = "Pickachu is the best a killing rocks", Rating = 5,
                                Reviewer = new Reviewer(){ Name = "Taylor" } },
                                new Review { Title="Pikachu",Text = "Pickchu, pickachu, pikachu", Rating = 1,
                                Reviewer = new Reviewer(){ Name = "Jessica" } },
                            }
                        },
                        Owner = new Owner()
                        {
                            Name = "Jack",
                            Country = new Country()
                            {
                                Name = "Kanto"
                            }
                        }
                    },
                    new ThingOwner()
                    {
                        Thing = new Thing()
                        {
                            Name = "Squirtle",
                            CreatedDate = new DateTime(1903,1,1),
                            ThingCategories = new List<ThingCategory>()
                            {
                                new ThingCategory { Category = new Category() { Name = "Water"}}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title= "Squirtle", Text = "squirtle is the best pokemon, because it is electric", Rating = 5,
                                Reviewer = new Reviewer(){ Name = "Teddy" } },
                                new Review { Title= "Squirtle",Text = "Squirtle is the best a killing rocks", Rating = 5,
                                Reviewer = new Reviewer(){ Name = "Taylor" } },
                                new Review { Title= "Squirtle", Text = "squirtle, squirtle, squirtle", Rating = 1,
                                Reviewer = new Reviewer(){ Name = "Jessica" } },
                            }
                        },
                        Owner = new Owner()
                        {
                            Name = "Harry",
                            Country = new Country()
                            {
                                Name = "Saffron City"
                            }
                        }
                    },
                                    new ThingOwner()
                    {
                        Thing = new Thing()
                        {
                            Name = "Venasuar",
                            CreatedDate = new DateTime(1903,1,1),
                            ThingCategories = new List<ThingCategory>()
                            {
                                new ThingCategory { Category = new Category() { Name = "Leaf"}}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title="Veasaur",Text = "Venasuar is the best pokemon, because it is electric", Rating = 5,
                                Reviewer = new Reviewer(){ Name = "Teddy" } },
                                new Review { Title="Veasaur",Text = "Venasuar is the best a killing rocks", Rating = 5,
                                Reviewer = new Reviewer(){ Name = "Taylor" } },
                                new Review { Title="Veasaur",Text = "Venasuar, Venasuar, Venasuar", Rating = 1,
                                Reviewer = new Reviewer(){ Name = "Jessica" } },
                            }
                        },
                        Owner = new Owner()
                        {
                            Name = "Ash",
                            Country = new Country()
                            {
                                Name = "Millet Town"
                            }
                        }
                    }
                };
                dataContext.ThingOwners.AddRange(pokemonOwners);
                dataContext.SaveChanges();
            }
        }
    }
}