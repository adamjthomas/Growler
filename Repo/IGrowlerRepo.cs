using Growler.Models;
using System.Collections.Generic;

namespace Growler.Repo
{
    public interface IGrowlerRepo
    {
        IEnumerable<Brew> GetAllBrews();
        IEnumerable<Category> GetAllCategories();
        IEnumerable<Style> GetAllStyles();
        Brew GetBrewById(int id);
        Category GetCategoryById(string id);
        Style GetStyleById(string id);
    }
}