using Microsoft.AspNetCore.Mvc;

namespace lethicamtien_2123110341_asp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        static List<string> products = new List<string>()
        {
            "Apple",
            "Banana"
        };

        // GET: api/Product
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(products);
        }

        // GET: api/Product/1
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(products[id]);
        }

        // POST: api/Product
        [HttpPost]
        public IActionResult Add(string name)
        {
            products.Add(name);
            return Ok(products);
        }

        // PUT: api/Product/1
        [HttpPut("{id}")]
        public IActionResult Update(int id, string name)
        {
            products[id] = name;
            return Ok(products);
        }

        // DELETE: api/Product/1
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            products.RemoveAt(id);
            return Ok(products);
        }
    }
}