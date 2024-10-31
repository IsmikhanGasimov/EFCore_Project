using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Project1.Classes
{
    public class Book
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public int Price { get; set; }
        public bool InStock { get; set; }
        public int GId { get; set; }
        public Genre Genre { get; set; }
    }
}
