using BL.Implement;
using DAL.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectVTCA
{
    public class Category_view
    {
        public void Cag_view(CategoryService cagService)
        {
            string chon;
            Categories cag = new Categories();
            Menu menu = new Menu();
            Display display = new Display();
            do
            {
                menu.Menu_Cag();
                Console.Write("Chon:");
                chon = Console.ReadLine();
                switch (chon)
                {
                    case "0":
                        {

                            break;
                        }
                    case "1":
                        {
                            //Console.Write("Categories ID: ");
                            //cag.Cag_ID = int.Parse(Console.ReadLine());
                            Console.Write("Categories name: ");
                            cag.Cag_Name = Console.ReadLine();
                            cag.status = 1;
                            var result = cagService.Insert(cag);
                            if (result == 1)
                            {
                                Console.WriteLine("Insert succeed!");
                            }
                            else
                            {
                                Console.WriteLine("Insert failed!");
                            }

                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Enter categories information need to be updated!");
                            Console.Write("Enter ID: ");
                            int id = int.Parse(Console.ReadLine());
                            var result = cagService.GetByID(id);
                            if (result == null)
                            {
                                Console.WriteLine("Categories not found!");
                            }
                            else
                            {
                                //Console.Write("Categories ID: ");
                                //cag.Cag_ID = int.Parse(Console.ReadLine());
                                Console.Write("Categories name: ");
                                cag.Cag_Name = Console.ReadLine();
                                cag.status = 1;
                                cag.status = 1;
                                var result1 = cagService.Update(cag, id);
                                if (result1 == 1)
                                {
                                    Console.WriteLine("Update succeed!");
                                }
                                else
                                {
                                    Console.WriteLine("Update failed!");
                                }
                            }
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("Categories ID: ");
                            int id = int.Parse(Console.ReadLine());
                            var result = cagService.GetByID(id);
                            if (result == null)
                            {
                                Console.WriteLine("Categories not found!");
                            }
                            else
                            {
                                var result1 = cagService.Delete(id);
                                if (result1 == 1)
                                {
                                    Console.WriteLine("Delete succeed!");
                                }
                                else
                                {
                                    Console.WriteLine("Delete failed!");
                                }
                            }
                            break;
                        }
                    case "4":
                        {
                            var list = cagService.GetAll();
                            display.Display_cag(list);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("error!!");
                            Console.WriteLine("|-------------------------------------------------------------------|");
                            break;
                        }
                }
            } while (chon != "0");
        }
    }
}

