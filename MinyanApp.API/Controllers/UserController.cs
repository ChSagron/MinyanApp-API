using Microsoft.AspNetCore.Mvc;
using MinyanApp.Core.Entities;
using MinyanApp.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MinyanApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: api/<UserController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_userService.GetList());
        }


        // todo! → jwt + login model
        // GET api/<UserController>/nickname
        [HttpGet("{nickname},{password}")]
        public IActionResult Get(string nickname, string password)
        {
            User user = _userService.FindUser(nickname, password);
            if (user == null)
            {
                return StatusCode(401);
            }
            return Ok(user);
        }




        // POST api/<UserController>
        [HttpPost]
        public IActionResult Post([FromBody] User user)
        {
            _userService.AddItem(user);
            return Ok(_userService.GetList().Last());
        }

        /*
 

     
        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        */
    }
}
