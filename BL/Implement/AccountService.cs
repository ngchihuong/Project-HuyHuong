using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Implement;
using BL.Interfaces;
using DAL.DBContext;

namespace BL.Implement
{
    public class AccountServices : SuperClass<Accounts>, ISuper<Accounts>, IAccount<Accounts>
    {

        public override int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override int Update(Accounts model, int id)
        {
            throw new NotImplementedException();
        }
        public int Delete(string username)
        {
            var result = db.Accounts.SingleOrDefault(x => x.username == username && x.Permission != 1);
            if (result != null)
            {
                result.status = 0;
                db.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public override int Insert(Accounts model)
        {
            var result = db.Accounts.Count(x => x.username == model.username);
            if (result == 0)
            {
                db.Accounts.Add(model);
                db.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int Update(Accounts model, string username)
        {
            var result = db.Accounts.Find(username);
            if (result == null)
            {
                return 0;
            }
            else
            {
                if (result.username == model.username)
                {
                    result.password = model.password;
                    result.status = model.status;
                    result.Employee_ID = model.Employee_ID;
                    result.Permission = model.Permission;
                    db.SaveChanges();
                    return 1;
                }
                else
                {
                    var count = db.Accounts.Count(x => x.username == model.username);
                    if (count == 0)
                    {
                        result.password = model.password;
                        result.status = model.status;
                        result.Employee_ID = model.Employee_ID;
                        result.Permission = model.Permission;
                        db.SaveChanges();
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
        }
        public List<Accounts> GetAll()
        {
            return db.Accounts.Where(x => x.status == 1).ToList();
        }

        public Accounts GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Accounts> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Accounts GetByUserName(string userName)
        {
            return db.Accounts.SingleOrDefault(x => x.username == userName && x.status == 1);
        }
        public Accounts GetByEmployeeID(int id)
        {
            return db.Accounts.SingleOrDefault(x => x.Employee_ID == id && x.status == 1);
        }
    }
}