using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.Data.Model
{
    public class Book
    {
        public int Id{ get; set; }
        public string Titulo { get; set; }
        public double Price { get; set; }
        public string genre { get; set; }
        public DateTime publishDate { get; set; }
        public string Description { get; set; }
    }
}
