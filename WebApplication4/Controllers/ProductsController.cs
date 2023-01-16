using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private List<Item> _items;
        public ProductsController()
        {
            _items = new List<Item>
            {
                new()
                {
                    Id = 1,
                    Name = "Monitor",
                    Quanity = 399,
                    State = "New"
                },
                new()
                {
                    Id = 2,
                    Name = "Keyboard",
                    Quanity = 32,
                    State = "New"
                },
                new()
                {
                    Id = 3,
                    Name = "Mouse",
                    Quanity = 29,
                    State = "Used"  
                },
                new()
                {
                    Id = 4,
                    Name = "Computer",
                    Quanity = 12,
                    State = "New"
                }
            };
        }
        [HttpPut]
        public IActionResult GetTestValues()
        {
            return Ok(new
            {
                Value1 = "A",
                Value2 = "B",
                Value3 = "C",
                Value4 = "D",

            });
        }
        [HttpPut("{id:int}")]
        public IActionResult GetItem(int id)
        {
            var item = _items.FirstOrDefault(i => i.Id == id);
            if (item is null) return NotFound();
            return Ok(item);
        }
    }
}
