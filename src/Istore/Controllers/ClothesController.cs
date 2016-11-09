using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Istore.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Istore.Controllers
{
    [Route("api/[controller]")]
    public class ClothesController : Controller
    {
        static List<Clothes> _clothes = new List<Clothes>
      {
          new Clothes {Id=1, Name="Telefe", Price= 350.70m},
          new Clothes {Id=2, Name="Limute ", Price= 100.00m},
          new Clothes {Id=3, Name="Ye'Raya", Price= 120.70m},
          new Clothes {Id=4, Name="Makesi ", Price= 140.99m},
          new Clothes {Id=5, Name="Ye'Welayta", Price= 200.00m},
          new Clothes {Id=6, Name="Ye'Gojam", Price= 115.00m},
          new Clothes {Id=7, Name="Ye'Gonder", Price= 105.00m},
          new Clothes {Id=8, Name="Eterter", Price= 135.00m}

      };
        public IEnumerable<Clothes> Get()
        {
            return _clothes;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Clothes istore = _clothes.Find(i => i.Id == id);
            if(istore == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(istore);
            }
        }
        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Clothes clothe)
        {
            _clothes.Add(clothe);
            return Created("/istores/" + clothe.Id, clothe);
        }
/*
        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        } */
    }
}
