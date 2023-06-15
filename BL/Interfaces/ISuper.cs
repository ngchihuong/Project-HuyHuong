using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interfaces
{
     public interface ISuper<V>
    {
         List<V> GetAll();
        V GetByID(int id); 
        List<V> GetByName(string name);
    }
}
