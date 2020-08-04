using Growler.Models;
using System.Collections.Generic;

namespace Growler.Repo
{
    public class MockGrowlerRepo : IGrowlerRepo
    {
        public IEnumerable<Brew> GetAllBrews()
        {
            var brews = new List<Brew>
            {
                new Brew
                {
                    Id = 1,
                    Name = "Adam's Brew",
                    Category = new Category
                    {
                        Id = "1",
                        Name = "Standard American Beer",
                        Introduction = "Introduction"
                    },
                    Style = new Style
                    {
                        Id = "1A",
                        Name = "American Light Lager",
                        OverallImpression = "",
                        Aroma = "",
                        Appearance = "",
                        Flavor = "",
                        Mouthfeel = "",
                        Comments = "",
                        History = "",
                        CharacteristicIngredients = "",
                        OG = "",
                        IBUs = "",
                        FG = "",
                        SRM = "",
                        ABV = ""
                    }
                },

                new Brew
                {
                    Id = 2,
                    Name = "Erics Brew",
                    Category = new Category
                    {
                        Id = "1",
                        Name = "Standard American Beer",
                        Introduction = "Introduction",
                    },
                    Style = new Style
                    {
                        Id = "1A",
                        Name = "American Light Lager",
                        OverallImpression = "",
                        Aroma = "",
                        Appearance = "",
                        Flavor = "",
                        Mouthfeel = "",
                        Comments = "",
                        History = "",
                        CharacteristicIngredients = "",
                        OG = "",
                        IBUs = "",
                        FG = "",
                        SRM = "",
                        ABV = ""
                    }
                },

                new Brew {
                    Id = 3,
                    Name = "Levi's Brew",
                    Category = new Category
                    {
                        Id = "1",
                        Name = "Standard American Beer",
                        Introduction = "Introduction"
                    },
                    Style = new Style
                    {
                        Id = "1A",
                        Name = "American Light Lager",
                        OverallImpression = "",
                        Aroma = "",
                        Appearance = "",
                        Flavor = "",
                        Mouthfeel = "",
                        Comments = "",
                        History = "",
                        CharacteristicIngredients = "",
                        OG = "",
                        IBUs = "",
                        FG = "",
                        SRM = "",
                        ABV = ""
                    }
                }
            };

            return brews;
        }

        public Brew GetBrewById(int id)
        {
            Brew brewObj = new Brew
            {
                Id = 1,
                Name = "Adam's Brew",
                Category = new Category
                {
                    Id = "1",
                    Name = "Standard American Beer",
                    Introduction = "Something"
                },
                Style = new Style
                {
                    Id = "1A",
                    Name = "American Light Lager",
                    OverallImpression = "",
                    Aroma = "",
                    Appearance = "",
                    Flavor = "",
                    Mouthfeel = "",
                    Comments = "",
                    History = "",
                    CharacteristicIngredients = "",
                    OG = "",
                    IBUs = "",
                    FG = "",
                    SRM = "",
                    ABV = ""
                }
            };

            return brewObj;
        }
    }
}
