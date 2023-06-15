using BL.Implement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectVTCA
{
    public class CustomerLogin
    {
        public void CusLog(CategoryService categoryService , ProductService productService)
        {
            Menu menu = new Menu();
            Display display = new Display();

            string chon1;
            do
            {
                menu.Menu_Cus();
                Console.WriteLine("Enter your choice : ");
                chon1 = Console.ReadLine();
                switch (chon1)
                {
                    case "0":
                        {
                            Console.WriteLine("You have exited this feature!");
                            break;
                        }
                    case "1":
                        {
                            var list = categoryService.GetAll();
                            display.Display_cag(list);
                            break;
                        }
                    case "2":
                        {
                            var list = productService.GetAll();
                            display.Display_pro(list, categoryService);
                            break;
                        }
                    case "3":
                        {
                            Console.Write("Product's ID :");
                            int id = int.Parse(Console.ReadLine());
                            var result = productService.GetByID(id);
                            display.Display_pro1(result, categoryService);
                            break;
                        }
                    case "4":
                        {
                            Console.Write("Product's Cag_id :");
                            int id = int.Parse(Console.ReadLine());
                            var result = productService.GetByCagID(id);
                            display.Display_pro(result, categoryService);
                            break;

                        }
                    case "5":
                        {
                            Console.Write("Enter day :");
                            int day = int.Parse(Console.ReadLine());
                            Console.Write("Enter month : ");
                            int month = int.Parse(Console.ReadLine());
                            Console.Write("Enter year : ");
                            int year = int.Parse(Console.ReadLine());
                            DateTime date1 = new DateTime(year, month, day);
                            Console.Write("Enter day :");
                            int day1 = int.Parse(Console.ReadLine());
                            Console.Write("Enter month : ");
                            int month1 = int.Parse(Console.ReadLine());
                            Console.Write("Enter year : ");
                            int year1 = int.Parse(Console.ReadLine());
                            DateTime date2 = new DateTime(year1, month1, day1);
                            var result = productService.GetByDate_Added(date1, date2);
                            display.Display_pro(result, categoryService);
                            break;
                        }
                    case "6":
                        {
                            Console.Write("Product's name :");
                            string name = Console.ReadLine();
                            var result = productService.GetByName(name);
                            display.Display_pro(result, categoryService);
                            break;
                        }
                    case "7":
                        {
                            Console.Write("Price 1 :");
                            decimal price1 = decimal.Parse(Console.ReadLine());
                            Console.Write("Price 2 :");
                            decimal price2 = decimal.Parse(Console.ReadLine());
                            var result = productService.GetByPrice(price1, price2);
                            display.Display_pro(result, categoryService);
                            break;
                        }
                    case "8":
                        {
                            Console.Write("Description :");
                            string description = Console.ReadLine();
                            var result = productService.GetBy_Description(description);
                            display.Display_pro(result, categoryService);
                            break;
                        }
                    default:
                        break;
                }
            } while (chon1 != "0");

        }
    }
}
