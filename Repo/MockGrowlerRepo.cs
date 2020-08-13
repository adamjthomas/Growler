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
                        Id = 1,
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
                        Id = 1,
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
                        Id = 1,
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

        public IEnumerable<Category> GetAllCategories()
        {
            var categories = new List<Category>
            {
                new Category
                {
                    Id = 1,
                    Name = "",
                    Introduction = ""
                },

                new Category
                {
                    Id = 1,
                    Name = "",
                    Introduction = ""
                }
            };

            return categories;
        }

        public IEnumerable<Style> GetAllStyles()
        {
            var styles = new List<Style>
            {
                new Style
                {
                    Id = "",
                    Name = "",
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
                },

                new Style
                {
                    Id = "",
                    Name = "",
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

            return styles;
        }

        public Brew GetBrewById(int id)
        {
            Brew brew = new Brew
            {
                Id = 1,
                Name = "Adam's Brew",
                Category = new Category
                {
                    Id = 1,
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

            return brew;
        }

        public Category GetCategoryById(string id)
        {
            Category category = new Category
            {
                Id = 1,
                Name = "",
                Introduction = ""
            };

            return category;
        }

        public Style GetStyleById(string id)
        {
            Style style = new Style
            {
                Id = "",
                Name = "",
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
            };

            return style;
        }
    }
}
