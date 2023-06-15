using BL.Implement;
using BL.Interfaces;
using DAL.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectVTCA
{
    public class Customer_ViewAD
    {
        public void View_Cus(CustomerServices customerServices)
        {
            string chon;

            Menu menu = new Menu();
            Display display = new Display();
            do
            {
                menu.View_Cus();
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
                            var list = customerServices.GetAll();
                            display.Display_cus(list);
                            break;
                        }
                    case "2":
                        {
                            Console.Write("Customer's ID :");
                            int id = int.Parse(Console.ReadLine());
                            var result = customerServices.GetByID(id);
                            display.Display_cus1(result);
                            break;
                        }
                    case "3":
                        {
                            Console.Write("Customer's address :");
                            string address = Console.ReadLine();
                            var result = customerServices.GetByAddress(address);
                            display.Display_cus(result);
                            break;

                        }
                    case "4":
                        {
                            Console.Write("Customer's email :");
                            string email = Console.ReadLine();
                            var result = customerServices.GetByEmail(email);
                            display.Display_cus(result);
                            break;
                        }
                    case "5":
                        {
                            Console.Write("Customer's name :");
                            string name = Console.ReadLine();
                            var result = customerServices.GetByName(name);
                            display.Display_cus(result);
                            break;
                        }
                    case "6":
                        {
                            Console.Write("Customer's phone number :");
                            string phone = Console.ReadLine();
                            var result = customerServices.GetByPhone(phone);
                            display.Display_cus(result);
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

