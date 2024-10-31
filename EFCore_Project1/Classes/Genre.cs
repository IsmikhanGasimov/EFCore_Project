using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Project1.Classes
{
    public class Genre
    {
        public int Id { get; set; }
        public string Genres { get; set; }
        public ICollection<Book> Books{ get; set; }
    }
}
