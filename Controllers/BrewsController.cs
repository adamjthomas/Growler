using System.Collections.Generic;
using Growler.Models;
using Growler.Repo;
using Microsoft.AspNetCore.Mvc;

namespace Growler.Controllers
{
    // api/brews
    [Route("api/{controller}")]
    [ApiController]
    public class BrewsController : ControllerBase
    {
        private readonly MockGrowlerRepo _repository = new MockGrowlerRepo();

        // GET: api/brews
        [HttpGet]
        public ActionResult<IEnumerable<Brew>> GetAllBrews()
        {
            var brewItems = _repository.GetAllBrews();

            return Ok(brewItems);
        }

        // GET: api/brews/{id}
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Brew>> GetBrewById(int id)
        {
            var brewItem = _repository.GetBrewById(id);

            return Ok(brewItem);
        }
    }
}