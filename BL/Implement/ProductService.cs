using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Interfaces;
using DAL.DBContext;

namespace BL.Implement
{
    public class ProductService : SuperClass<Products>, ISuper<Products>, IProduct<Products>
    {
        public override int Delete(int id)
        {
            //Change the state from 1 to 0 ,  from display to hide
            var result = db.Products.Find(id);
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

        public List<Products> GetAll()
        {
            return db.Products.Where(x => x.status == 1).ToList();
        }

        public List<Products> GetByCagID(int id)
        {
            List<Products> result = db.Categories
                                .Join(db.Products,
                                    c => c.Cag_ID,
                                    p => p.Cag_ID,
                                    (c, p) => p)
                                .Where(p => p.Cag_ID == id && p.status == 1)
                                .ToList();
            return result;
        }
        public List<Products> GetByDate_Added(DateTime date_added , DateTime date_added2)
        {
            return db.Products.Where(x => x.Date_Added >= date_added && x.Date_Added <= date_added2 && x.status == 1).ToList();
        }

        public Products GetByID(int id)
        {
            return db.Products.SingleOrDefault(x => x.Pro_ID == id && x.status == 1);
        }

        public List<Products> GetByName(string name)
        {
            return db.Products.Where(x => x.Pro_Name.Contains(name) && x.status == 1).ToList();
        }

        public List<Products> GetByPrice(decimal price1, decimal price2)
        {
            List<Products> result = db.Products
                            .Where(p => p.Price >= price1 && p.Price <= price2 && p.status == 1)
                            .ToList();
            return result;
        }

        public List<Products> GetBy_Description(string description)
        {
            return db.Products.Where(x => x.Description.Contains(description) && x.status == 1).ToList();
        }

        public override int Insert(Products model)
        {
            var result = db.Products.Count(x => x.Pro_ID == model.Pro_ID);
            if (result == 0)
            {
                db.Products.Add(model);
                db.SaveChanges();
                return 1;
            }
            else 
            { 
                return 0; 
            }
            
        }
        public override int Update(Products model, int id)
        {
            var result = db.Products.Find(id);
            if (result == null)
            {
                // ko tim thay id de cap nhat
                return 0;
            }
            else
            {
                // khong cap nhat id
                if (result.Pro_ID == model.Pro_ID)
                {
                    result.Pro_Name = model.Pro_Name;
                    result.Cag_ID = model.Cag_ID;
                    result.Date_Added = model.Date_Added;
                    result.Description = model.Description;
                    result.Price = model.Price;
                    result.Quantity = model.Quantity;
                    result.Pro_Brand = model.Pro_Brand;
                    result.status = model.status;
                    db.SaveChanges();
                    return 1;
                }
                else
                {
                    var count = db.Products.Count(x => x.Pro_ID == model.Pro_ID);
                    if (count == 0)
                    {
                        result.Pro_Name = model.Pro_Name;
                        result.Cag_ID = model.Cag_ID;
                        result.Date_Added = model.Date_Added;
                        result.Description = model.Description;
                        result.Price = model.Price;
                        result.Quantity = model.Quantity;
                        result.Pro_Brand = model.Pro_Brand;
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
