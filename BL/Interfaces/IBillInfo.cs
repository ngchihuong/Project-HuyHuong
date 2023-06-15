using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface BillInfo<V>
    {
        V GetByID(int id);
        List<V> GetByBill_ID(int Bill_ID);
        List<V> GetByPro_ID(int Pro_ID);
    }
}
