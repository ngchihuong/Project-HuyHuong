using DAL.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface IProduct<V>
    {
        List<V> GetByCagID(int id);
        List<V> GetByDate_Added(DateTime date_added ,  DateTime date_added2);
        List<V> GetBy_Description (string description);
        List<V> GetByPrice (decimal price1 , decimal price2);
    }
}
