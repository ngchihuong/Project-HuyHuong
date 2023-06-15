using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DBContext
{
    public class BillInfo
    {
        public int Bill_Info_ID { get; set; }
        public int Bill_ID { get; set; }
        public int Pro_ID { get; set; }
        public int quantity { get; set; }
        public int status { get; set; }
        public Bill Bill { get; set; }
        public Products Product { get; set; }
    }
}