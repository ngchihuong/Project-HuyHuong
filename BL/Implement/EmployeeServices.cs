using BL.Interfaces;
using DAL.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Implement
{
    public class EmployeeServices : SuperClass<Employees>, ISuper<Employees>, IEmployee<Employees>
    {
        public override int Delete(int id)
        {
            //Change the state from 1 to 0 ,  from display to hide
            var result = db.Employees.SingleOrDefault(x => x.Employee_ID == id && x.Employee_ID != 1);
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

        public List<Employees> GetAll()
        {
            return db.Employees.Where(x => x.status == 1).ToList();
        }

        public List<Employees> GetByAddress(string address)
        {
            return db.Employees.Where(x => x.Address.Contains(address) && x.status == 1).ToList();
        }
        public List<Employees> GetByAge(int age)
        {
            return db.Employees.Where(x => x.Age == age && x.status == 1).ToList();
        }

        public List<Employees> GetByEmail(string email)
        {
            return db.Employees.Where(x => x.Email == email && x.status == 1).ToList();
        }

        public Employees GetByID(int id)
        {
            return db.Employees.SingleOrDefault(x => x.Employee_ID == id && x.status == 1);
        }

        public List<Employees> GetByName(string name)
        {
            return db.Employees.Where(x => x.Employee_Name.Contains(name) && x.status == 1).ToList();
        }

        public List<Employees> GetByPhone(string phone)
        {
            return db.Employees.Where(x => x.Phone_Number == phone && x.status == 1).ToList();
        }

        public override int Insert(Employees model)
        {
            var result = db.Employees.Count(x => x.Employee_ID == model.Employee_ID );
            if (result == 0)
            {
                db.Employees.Add(model);
                db.SaveChanges();
                return 1;
            }
            else { return 0; }
        }

        public override int Update(Employees model, int id)
        {
            var result = db.Employees.Find(id);
            if (result == null)
            {
                // ko tim thay id de cap nhat
                return 0;
            }
            else
            {
                // khong cap nhat id
                if (result.Employee_ID == model.Employee_ID)
                {
                    result.Employee_Name = model.Employee_Name;
                    result.Age = model.Age;
                    result.Phone_Number = model.Phone_Number;
                    result.Email = model.Email;
                    result.status = model.status;
                    db.SaveChanges();
                    return 1;
                }
                else
                {
                    var count = db.Employees.Count(x => x.Employee_ID == model.Employee_ID);
                    if (count == 0)
                    {
                        //result.Employee_ID = model.Employee_ID;
                        result.Employee_Name = model.Employee_Name;
                        result.Age = model.Age;
                        result.Phone_Number = model.Phone_Number;
                        result.Email = model.Email;
                        result.status = model.status;
                        db.SaveChanges();
                        return 1;
                    }
                    else
                    {
                        //tuc la trung id voi khach hang khac 
                        return -1;
                    }
                }
            }
        }
    }
}