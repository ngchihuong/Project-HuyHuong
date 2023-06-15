using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DBContext
{
    public class Customers
    {
        public int Cus_ID { get; set; }
        public string Cus_Name { get; set; }
        public string Email { get; set; }
        public string Cus_Phone { get; set; }
        public string Address { get; set; }
        public int status { get; set; }
        public ICollection<Bill> Bills_c { get; set; }
    }
}
