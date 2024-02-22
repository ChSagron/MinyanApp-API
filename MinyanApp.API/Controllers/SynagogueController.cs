using Microsoft.AspNetCore.Mvc;
using MinyanApp.Core.Entities;
using MinyanApp.Core.Services;
using MinyanApp.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MinyanApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SynagogueController : ControllerBase
    {
        private readonly ISynagogueService _synagogueService;
        private readonly ILocationService _locationService;


        public SynagogueController(ISynagogueService synagogueService, ILocationService locationService)
        {
            _synagogueService = synagogueService;
            _locationService = locationService;
        }



        // GET: api/<SynagogueController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_synagogueService.GetList());
        }

        // GET api/<SynagogueController>/5
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_synagogueService.GetById(id));
        }

        // GET api/<SynagogueController>/5
        [HttpGet("{lat},{lng}")]
        public IActionResult GetTop10(double lat, double lng)
        {
            return Ok(_locationService.GetTop10Synagogue(new Location() { Latitude = lat , Longitude = lng}));
        }



        // POST api/<SynagogueController>
        [HttpPost]
        public IActionResult Post([FromBody] Synagogue synagogue)
        {
            _synagogueService.AddItem(synagogue);
            //Where(s => s.Name == synagogue.Name)

            return Ok(_synagogueService.GetList().Last());
        }


        /*

        // DELETE api/<SynagogueController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        */
    }
}
