using Microsoft.AspNetCore.Mvc;
using Server.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private static List<User> users = new List<User>
        {
            new User{
                Id=0,Name="Efrat",Address="Harav shach",Mail="efros5566@gmail.com",Password="efros5566" },
            new User{ Id=1,Name="Riki",Address="Berinboim",Mail="rikim8423@gmail.com",Password="rikim8423" },
            new User{ Id=2,Name="Batya",Address="bney",Mail="123@gmail.com",Password="123" },
            new User{ Id=2,Name="gita",Address="brak",Mail="456@gmail.com",Password="456" },
        };
            // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return users;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var user = users.Find((x)=>x.Id==id);
            if (user == null)
                return NotFound();
            return Ok(user);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] User value)
        {
            users.Add(value);
            
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] User value)
        {
            var user = users.Find((x) => x.Id == id);
            if (user == null)
                return;
            user.Mail = value.Mail;
            user.Password = value.Password;
            user.Name = value.Name;
            user.Address = value.Address;
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var user = users.Find(x => x.Id == id);
            if (user == null)
                return;
            users.Remove(user);
        }
    }
}
