using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DBContext
{
    public class Accounts
    {
        public string  username { get; set; }
        public string password { get; set; }
        public int Employee_ID { get; set; }
        public int Permission { get; set; }
        public int status { get; set; }
        public ICollection<Bill> Bills { get; set; }
        public virtual Employees Employees { get; set; }
    }
}
