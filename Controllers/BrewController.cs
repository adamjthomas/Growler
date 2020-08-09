using Growler.Models;
using Growler.Repo;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Growler.Controllers
{
    // api/brew
    [Route("api/{controller}")]
    [ApiController]
    public class BrewController : ControllerBase
    {
        private readonly MockGrowlerRepo _repository = new MockGrowlerRepo();

        // GET: api/brew
        [HttpGet]
        public ActionResult<IEnumerable<Brew>> GetAllBrews()
        {
            var brewItems = _repository.GetAllBrews();

            return Ok(brewItems);
        }

        // GET: api/brew/{id}
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Brew>> GetBrewById(int id)
        {
            var brewItem = _repository.GetBrewById(id);

            return Ok(brewItem);
        }
    }
}