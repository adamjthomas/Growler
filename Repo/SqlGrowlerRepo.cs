using Growler.Models;
using System.Collections.Generic;
using System.Linq;

namespace Growler.Repo
{
    public class SqlGrowlerRepo : IGrowlerRepo
    {
        private readonly GrowlerContext _context;

        public SqlGrowlerRepo(GrowlerContext context)
        {
            _context = context;
        }

        public IEnumerable<Brew> GetAllBrews()
        {
            return _context.Brews.ToList();
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _context.Categories.ToList();
        }

        public IEnumerable<Style> GetAllStyles()
        {
            return _context.Styles.ToList();
        }

        public Brew GetBrewById(int id)
        {
            return _context.Brews.FirstOrDefault(p => p.Id == id);
        }

        public Category GetCategoryById(int id)
        {
            return _context.Categories.FirstOrDefault(p => p.Id == id);
        }

        public Style GetStyleById(string id)
        {
            return _context.Styles.FirstOrDefault(p => p.Id == id);
        }
    }
}