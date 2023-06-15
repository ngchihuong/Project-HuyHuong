using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DBContext
{
    public class Products
    {
        public int Pro_ID { get; set; }
        public string Pro_Name { get; set; }
        public int Cag_ID { get; set; }
        public DateTime Date_Added { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Pro_Brand { get; set; }
        public int status { get; set; }
        public ICollection<BillInfo> BillInfos { get; set; }
        public Categories Category { get; set; }
    }
}
