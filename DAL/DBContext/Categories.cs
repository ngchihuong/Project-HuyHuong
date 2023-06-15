using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DBContext
{
    public class Categories
    {
        public int Cag_ID { get; set; }
        public string Cag_Name { get; set; }
        public int status { get; set; }
        public ICollection<Products> products { get; set; }
    }
}
