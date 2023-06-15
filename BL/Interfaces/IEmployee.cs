using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface IEmployee<V>
    {
       List<V> GetByAge(int age);
        List<V> GetByPhone (string phone);
        List<V> GetByAddress(string address);
        List<V> GetByEmail(string email);
    }
}
