using Microsoft.AspNetCore.Mvc;
using Server.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecepiesController : ControllerBase
    {
        private static List<Recepies> recepies = new List<Recepies>
        {
            new Recepies{
                Id_Recipies=0,Name="ChocladCake",Id_Category=3,Time=50,Darga=Darga.five,Id_User=1,Date=DateTime.Now,ImgUrl="1.png",Procces=new List<string>{"toBake","put in the oven","to eat"},Products=new List<string>{"shokolad","candies" } },
                new Recepies{ Id_Recipies=1,Name="Pizza",Id_Category=3,Time=50,Darga=Darga.five,Id_User=1,Date=DateTime.Now,ImgUrl="1.png",Procces=new List<string>{"toBake","put in the oven","to eat"},Products=new List<string>{"shokolad","candies" } },
                new Recepies{   Id_Recipies=2,Name="falafel",Id_Category=3,Time=50,Darga=Darga.five,Id_User=1,Date=DateTime.Now,ImgUrl="1.png",Procces=new List<string>{"toBake","put in the oven","to eat"},Products=new List<string>{"shokolad","candies" } }
        };
        [HttpGet]
        public IEnumerable<Recepies> Get()
        {
            return recepies;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var rec = recepies.Find((x) => x.Id_Recipies == id);
            if (rec == null)
                return NotFound();
            return Ok(rec);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Recepies value)
        {
            recepies.Add(value);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Recepies value)
        {
            var rec=recepies.Find((x) => x.Id_Recipies == id);
            if (rec == null)
                return;
            rec.Products=value.Products;
            rec.Procces=value.Procces;
            rec.Date=value.Date;
            rec.ImgUrl=value.ImgUrl;
            rec.Id_User=value.Id_User;
            rec.Id_Recipies=value.Id_Recipies;
            rec.Darga=value.Darga;
            rec.Id_Category=value.Id_Category;
            rec.Name=value.Name;
            rec.Time=value.Time;
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var rec=recepies.Find(x=>x.Id_Recipies==id);
            if (rec == null)
                return;
            recepies.Remove(rec);
        }
    }
}
