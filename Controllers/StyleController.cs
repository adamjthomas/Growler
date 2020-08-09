using Growler.Models;
using Growler.Repo;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Growler.Controllers
{
    // api/style
    [Route("api/{controller}")]
    [ApiController]
    public class StyleController : ControllerBase
    {
        private readonly MockGrowlerRepo _repository = new MockGrowlerRepo();

        // GET: api/style
        [HttpGet]
        public ActionResult<IEnumerable<Style>> GetAllStyles()
        {
            var styleItems = _repository.GetAllStyles();

            return Ok(styleItems);
        }

        // GET: api/style/{id}
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Style>> GetStyleById(string id)
        {
            var styleItem = _repository.GetStyleById(id);

            return Ok(styleItem);
        }
    }
}