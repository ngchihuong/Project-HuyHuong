using BL.Interfaces;
using DAL.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Implement
{
    public class BillService : SuperClass<Bill>, ISuper<Bill>, IBills<Bill>
    {
        public override int Delete(int id)
        {
            var result = db.Bills.Find(id);
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

        public List<Bill> GetAll()
        {
            return db.Bills.Where(x => x.status == 1).ToList();
        }

        public Bill GetByID(int id)
        {
            return db.Bills.SingleOrDefault(x => x.Bill_ID == id && x.status == 1);
        }

        public List<Bill> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Bill> GetBySaleDated(DateTime Firstdate, DateTime LastDate)
        {
            List<Bill> result = db.Bills
                .Where(c => c.Sale_Date >= Firstdate && c.Sale_Date <= LastDate && c.status == 1).ToList();
            return result;
        }
        public List<Bill> GetByUserName(string username)
        {
            return db.Bills.Where(x => x.username == username).ToList();
        }

        public override int Insert(Bill model)
        {

            db.Bills.Add(model);
            db.SaveChanges();
            return 1;

        }

        public override int Update(Bill model, int id)
        {
            var result = db.Bills.Find(id);
            if (result == null)
            {
                return 0;
            }
            else
            {
                if (result.Bill_ID == model.Bill_ID)
                {
                    result.username = model.username;
                    result.Sale_Date = model.Sale_Date;
                    result.total_Price = model.total_Price;
                    result.Cus_ID = model.Cus_ID;
                    result.status = model.status;
                    db.SaveChanges();
                    return 1;
                }
                else
                {
                    var count = db.Bills.Count(x => x.Bill_ID == model.Bill_ID);
                    if (count == 0)
                    {
                        result.username = model.username;
                        result.Sale_Date = model.Sale_Date;
                        result.total_Price = model.total_Price;
                        result.Cus_ID = model.Cus_ID;
                        result.status = model.status;
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
    }
}
