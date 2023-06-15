using BL.Interfaces;
using DAL.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Implement
{
    public class CustomerServices : SuperClass<Customers>, ISuper<Customers>, ICustomer<Customers>
    {
        public override int Insert(Customers model)
        {

            var result = db.Customers.Count(x => x.Cus_ID == model.Cus_ID);
            if (result == 0)
            {
                db.Customers.Add(model);
                db.SaveChanges();
                return 1;
            }
            else { return 0; }
        }
        public override int Update(Customers model, int id)
        {
            var result = db.Customers.Find(id);
            if (result == null)
            {
                // ko tim thay id de cap nhat
                return 0;
            }
            else
            {
                // khong cap nhat id
                if (result.Cus_ID == model.Cus_ID)
                {
                    result.Cus_Name = model.Cus_Name;
                    result.Email = model.Email;
                    result.Cus_Phone = model.Cus_Phone;
                    result.status = model.status;
                    db.SaveChanges();
                    return 1;
                }
                else
                {
                    var count = db.Customers.Count(x => x.Cus_ID == model.Cus_ID);
                    if (count == 0)
                    {
                        //result.Cus_ID = model.Cus_ID;
                        result.Cus_Name = model.Cus_Name;
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
        public override int Delete(int id)
        {
            //Change the state from 1 to 0 ,  from display to hide
            var result = db.Customers.Find(id);
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

        public List<Customers> GetAll()
        {
            return db.Customers.Where(x => x.status == 1).ToList();
        }

        public Customers GetByID(int id)
        {
            return db.Customers.SingleOrDefault(x => x.Cus_ID == id && x.status == 1);
        }

        public List<Customers> GetByName(string name)
        {
            return db.Customers.Where(x => x.Cus_Name.Contains(name) && x.status == 1).ToList();
        }

        public List<Customers> GetByEmail(string email)
        {
            return db.Customers.Where(x => x.Email.Contains(email) && x.status == 1).ToList();
        }

        public List<Customers> GetByPhone(string phone)
        {
            return db.Customers.Where(x => x.Cus_Phone.Contains(phone) && x.status == 1).ToList();
        }

        public List<Customers> GetByAddress(string address)
        {
            return db.Customers.Where(x => x.Address.Contains(address) && x.status == 1).ToList();
        }
    }
}
