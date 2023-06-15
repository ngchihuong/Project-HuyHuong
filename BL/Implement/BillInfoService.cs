using DAL.DBContext;
using BL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Implement
{
    public class BillInfoService : SuperClass<BillInfo>, BillInfo<BillInfo>
    {
        public override int Delete(int id)
        {
            var result = db.BillInfos.Find(id);
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

        public List<BillInfo> GetByBill_ID(int Bill_ID)
        {
            return db.BillInfos.Where(x => x.Bill_ID == Bill_ID && x.status == 1).ToList();
        }

        public BillInfo GetByID(int id)
        {
            return db.BillInfos.SingleOrDefault(x => x.Bill_Info_ID == id && x.status == 1);
        }

        public List<BillInfo> GetByPro_ID(int Pro_ID)
        {
            return db.BillInfos.Where(x => x.Pro_ID== Pro_ID).ToList();
        }

        public override int Insert(BillInfo model)
        {
            var result = db.BillInfos.Count(x => x.Bill_Info_ID == model.Bill_Info_ID);
            if (result == 0)
            {
                db.BillInfos.Add(model);
                db.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public override int Update(BillInfo model, int id)
        {
            var result = db.BillInfos.Find(id);
            if (result == null)
            {
                return 0;
            }
            else
            {
                if (result.Bill_Info_ID == model.Bill_Info_ID)
                {
                    //result.Bill_ID = model.Bill_ID;
                    result.Pro_ID = model.Pro_ID;
                    result.quantity = model.quantity;
                    result.status = model.status;
                    db.SaveChanges();
                    return 1;
                }
                else
                {
                    var count = db.BillInfos.Count(x => x.Bill_Info_ID == model.Bill_Info_ID);
                    if (count == 0)
                    {
                        //result.Bill_ID = model.Bill_ID;
                        result.Pro_ID = model.Pro_ID;
                        result.quantity = model.quantity;
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