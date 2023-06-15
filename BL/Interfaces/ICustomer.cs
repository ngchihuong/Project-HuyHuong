using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.DBContext;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface ICustomer<V>
    {
        List<V> GetByEmail(string email);
        List<V> GetByPhone(string phone);
        List<V> GetByAddress(string address);
    }
}
