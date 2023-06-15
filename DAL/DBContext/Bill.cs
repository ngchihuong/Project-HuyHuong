using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DBContext
{
    public class Bill
    {
        public int Bill_ID { get; set; }
        public int Cus_ID { get; set; }
        public string username { get; set; }
        public DateTime Sale_Date { get; set; }
        public decimal total_Price { get; set; }
        public int status { get; set; }
        public ICollection<BillInfo> billInfos { get; set; }
        public Accounts Account { get; set; }
        public Customers Customer { get; set; }
    }
}
