using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DBContext;

namespace BL.Interfaces
{
    public interface IAccount<V>
    {
        V GetByUserName (string userName);
        V GetByEmployeeID(int id);
    }
}
