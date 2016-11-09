using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Istore.Models
{
    public class Books
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public int PageNumber { get; set; }
    }
}