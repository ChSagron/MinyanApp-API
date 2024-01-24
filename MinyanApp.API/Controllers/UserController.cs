using Microsoft.AspNetCore.Mvc;
using MinyanApp.Core.Entities;
using MinyanApp.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MinyanApp.API.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class userController : ControllerBase
    {

        private readonly IUserService _userService;
        public userController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: api/<userController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _userService.GetList();
        }


        // POST api/<userController>
        [HttpPost]
        public void Post([FromBody] User user)
        {
            _userService.AddItem(user);
        }

        /*
        // GET api/<userController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

     
        // PUT api/<userController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<userController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        */
    }
}
