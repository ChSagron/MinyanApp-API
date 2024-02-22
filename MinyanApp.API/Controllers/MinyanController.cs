using Microsoft.AspNetCore.Mvc;
using MinyanApp.Core.Entities;
using MinyanApp.Core.Services;
using MinyanApp.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MinyanApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MinyanController : ControllerBase
    {

        private readonly IMinyanService _minyanService;
        private readonly ISynagogueService _synagogeService;


        public MinyanController(IMinyanService minyanService, ISynagogueService synagogeService)
        {
            _minyanService = minyanService;
            _synagogeService = synagogeService;
        }


        // GET: api/<MinyanController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_minyanService.GetList());
        }


        // POST api/<MinyanController>
        [HttpPost]
        public IActionResult Post([FromBody] Minyan minyan)
        {
            var minyanFromList = _minyanService.GetList().Count(m => m.DateTime == minyan.DateTime);
            if (minyanFromList == 0)
            {
                _minyanService.AddItem(minyan);
                return Ok(_minyanService.GetList().Last());
            }
            return StatusCode(401);
        }


        // POST api/<MinyanController/5>
        [HttpPost("{synagogueId}")]
        public IActionResult PostToSynagogue([FromBody] Minyan minyan, int synagogueId)
        {
            var minyanToList = Post(minyan);

            // todo! → date-time search only if same synagogue
            //var minyanToList = _minyanService.GetList().Count(m => /*m.Synagogue != null && m.Synagogue.Id == minyan.Synagogue.Id && */m.DateTime == minyan.DateTime);

            //if (minyanToList > 0)
            if (minyanToList is OkObjectResult)
            {
                _synagogeService.PutById(synagogueId, _minyanService.GetList().Last());
                return Ok(_minyanService.GetList().Last());
            }
            return StatusCode(401);
        }

        /*
        // GET api/<MinyanController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // PUT api/<MinyanController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MinyanController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        */
    }
}
