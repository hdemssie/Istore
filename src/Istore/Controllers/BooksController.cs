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
    public class BooksController : Controller
    {
        static List<Books> _books = new List<Books>
        {
            new Books {Id=1, Name= " Cutting for Stone", Author= "Cutting For Stone", Price=10.99m, PageNumber = 400},
            new Books {Id=2, Name= " The Kebra Nagast", Author= "E.A Wallis Budget", Price=31.72m, PageNumber = 430 },
            new Books {Id=3, Name= "The Life And Times Of Menelik II: Ethiopia 1844-1913 ", Author= "Harold G. Marcus ",Price=40.99m, PageNumber= 450},
            new Books {Id=4, Name= " King of Kings: The Triumph and Tragedy of Emperor Haile Selassie I of Ethiopia", Author= "Assfaw Wesson", Price=14.48m, PageNumber = 480 }
        };
        [HttpGet]
        public IEnumerable<Books> Get()
        {
            return _books;

        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Books books = _books.Find(p => p.Id == id);
            if (books== null)
            {
                return NotFound();
            }
            else
            {
                return Ok(books);
            }
        }
        // /api/products
        [HttpPost]
        public IActionResult Post([FromBody]Books book)
        {
            _books.Add(book);
            return Created("/books/" + book.Id, book);
        }
    }
}
