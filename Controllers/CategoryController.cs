using Microsoft.AspNetCore.Mvc;
using Server.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CategoryController : ControllerBase
    {
        private static List<Category> category = new List<Category>
        {
            new Category
            {
                Id = 1,
                Name="cakes",
                Url="cake/1"
            },
            new Category
            {
                Id = 2,
                Name="soups",
                Url="cake/1"
            },new Category
            {
                Id = 3,
                Name="iceCreams",
                Url="cake/1"
            }
        };
        // GET: api/<CategoryController>
        [HttpGet]
        public IEnumerable<Category> Get()
        {
            return category;
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var cat=category.Find(x=>x.Id==id);
            if (cat == null)
                return NotFound();
            return Ok(cat);
        }
        // POST api/<CategoryController>
        [HttpPost]
        public void Post([FromBody] Category value)
        {
            category.Add(value);
        }

        // PUT api/<CategoryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Category value)
        {
            var cat = category.Find(x => x.Id == id);
            if (cat == null)
                return;
            cat.Name=value.Name;
            cat.Url=value.Url;
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var cat=category.Find(x=>x.Id==id);
            if (cat == null)
                return;
            category.Remove(cat);
        }
    }
}
