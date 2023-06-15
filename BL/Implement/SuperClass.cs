using DAL.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Implement
{
    abstract public class SuperClass<V>
    {
        public DataBaseContext db =  new DataBaseContext();

        public abstract int Insert(V model);
        public abstract int Update(V model , int id);
        public abstract int Delete(int id);
    }
}
