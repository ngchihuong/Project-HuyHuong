using BL.Interfaces;
using DAL.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Implement
{
    public class CategoryService : SuperClass<Categories>, ISuper<Categories>
    {
        public override int Delete(int id)
        {
            //Change the state from 1 to 0 ,  from display to hide
            var result = db.Categories.Find(id);
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
        public List<Categories> GetAll()
        {
            return db.Categories.Where(x => x.status == 1).ToList();
        }

        public Categories GetByID(int id)
        {
            return db.Categories.SingleOrDefault(x => x.Cag_ID == id && x.status == 1);
        }

        public List<Categories> GetByName(string name)
        {
            return db.Categories.Where(x => x.Cag_Name.Contains(name) && x.status == 1).ToList();
        }

        public override int Insert(Categories model)
        {
            var result = db.Categories.Count(x => x.Cag_ID == model.Cag_ID);
            if (result == 0)
            {
                db.Categories.Add(model);
                db.SaveChanges();
                return 1;
            }
            else { return 0; }
        }

        public override int Update(Categories model, int id)
        {
            var result = db.Categories.Find(id);
            if (result == null)
            {
                // ko tim thay id de cap nhat
                return 0;
            }
            else
            {
                // khong cap nhat id
                if (result.Cag_ID == model.Cag_ID)
                {
                    result.Cag_Name = model.Cag_Name;
                    result.status = model.status;
                    db.SaveChanges();
                    return 1;
                }
                else
                {
                    var count = db.Categories.Count(x => x.Cag_ID == model.Cag_ID);
                    if (count == 0)
                    {
                        //result.Cag_ID = model.Cag_ID;
                        result.Cag_Name = model.Cag_Name;
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
