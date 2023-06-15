using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DBContext
{
    public class Employees
    {
        public int Employee_ID { get; set; }
        public string Employee_Name { get; set; }
        public int Age { get; set; }
        public string Phone_Number { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int status { get; set; }
        public virtual Accounts Accounts { get; set; }
    }
}
