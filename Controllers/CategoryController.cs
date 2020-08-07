using Microsoft.AspNetCore.Mvc;
using Growler.Models;
using Growler.Repo;
using System.Collections.Generic;

namespace Growler.Controllers
{
    // api/category
    [Route("api/{controller}")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly MockGrowlerRepo _repository = new MockGrowlerRepo();

        // GET: api/category
        [HttpGet]
        public ActionResult<IEnumerable<Category>> GetAllCategories()
        {
            var categoryItems = _repository.GetAllCategories();

            return Ok(categoryItems);
        }

        // GET: api/category/{id}
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Category>> GetCategoryById(string id)
        {
            var categoryItem = _repository.GetCategoryById(id);

            return Ok(categoryItem);
        }
    }
}