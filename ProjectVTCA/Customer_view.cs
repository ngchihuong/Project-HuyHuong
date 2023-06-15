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
    public class Customer_view
    {
        public void Cus_view(CustomerServices customerServices)
        {
            string chon;
           
            Menu menu = new Menu();
            Display display = new Display();
            do
            {
                menu.Menu_KH();
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
                            //Console.Write("Customer's ID: ");
                            //customers.Cus_ID = int.Parse(Console.ReadLine());
                            Customers customers = new Customers();
                            Console.Write("Customer's name: ");
                            customers.Cus_Name = Console.ReadLine();
                            string phone;
                            bool phone_valid = false;
                            do
                            {
                                Console.Write("Phone number: ");
                                phone = Console.ReadLine();
                                phone_valid = true;
                                if (!phone.StartsWith('0') || phone.Length != 10)
                                {
                                    phone_valid = false;
                                    Console.WriteLine("Phone number invalid!!!(Need 10 number and start with 0)");
                                }
                                else
                                {
                                    foreach (var num in phone)
                                    {
                                        if (!char.IsDigit(num))
                                        {
                                            phone_valid = false;
                                        }
                                        if (!phone_valid)
                                        {
                                            Console.WriteLine("Phone number invalid!!(Phone number just include number)");
                                        }
                                    }
                                }
                            } while (phone_valid == false);
                            customers.Cus_Phone = phone;
                            string email;
                            bool email_valid = false;
                            do
                            {
                                Console.Write("Email: ");
                                email = Console.ReadLine();
                                email_valid = true;
                                if (!email.EndsWith("@gmail.com"))
                                {
                                    email_valid = false;
                                    Console.WriteLine("Email invalid!");
                                }
                            } while (email_valid == false);
                            customers.Email = email;
                            Console.Write("Address: ");
                            customers.Address = Console.ReadLine();
                            customers.status = 1;
                            var result = customerServices.Insert(customers);
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
                            Customers customers = new Customers();
                            Console.WriteLine("Enter customer's information need to be updated!");
                            Console.Write("Enter ID: ");
                            int id = int.Parse(Console.ReadLine());
                            var result = customerServices.GetByID(id);
                            if (result == null)
                            {
                                Console.WriteLine("Customer not found!");
                            }
                            else
                            {
                                //Console.Write("Customer's ID: ");
                                //customers.Cus_ID = int.Parse(Console.ReadLine());
                                Console.Write("Customer's name: ");
                                customers.Cus_Name = Console.ReadLine();
                                string phone;
                                bool phone_valid = false;
                                do
                                {
                                    Console.Write("Phone number: ");
                                    phone = Console.ReadLine();
                                    phone_valid = true;
                                    if (!phone.StartsWith('0') || phone.Length != 10)
                                    {
                                        phone_valid = false;
                                        Console.WriteLine("Phone number invalid!!!(Need 10 number and start with 0)");
                                    }
                                    else
                                    {
                                        foreach (var num in phone)
                                        {
                                            if (!char.IsDigit(num))
                                            {
                                                phone_valid = false;
                                            }
                                            if (!phone_valid)
                                            {
                                                Console.WriteLine("Phone number invalid!!(Phone number just include number)");
                                            }
                                        }
                                    }
                                } while (phone_valid == false);

                                customers.Cus_Phone = phone;
                                string email;
                                bool email_valid = false;
                                do
                                {
                                    Console.Write("Email: ");
                                    email = Console.ReadLine();
                                    email_valid = true;
                                    if (!email.EndsWith("@gmail.com"))
                                    {
                                        email_valid = false;
                                        Console.WriteLine("Email invalid!");
                                    }
                                } while (email_valid == false);
                                customers.Email = email;
                                Console.Write("Address: ");
                                customers.Address = Console.ReadLine();
                                customers.status = 1;
                                var result1 = customerServices.Update(customers, id);
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
                            Console.WriteLine("Customer's ID: ");
                            int id = int.Parse(Console.ReadLine());
                            var result = customerServices.GetByID(id);
                            if (result == null)
                            {
                                Console.WriteLine("Customer not found!");
                            }
                            else
                            {
                                var result1 = customerServices.Delete(id);
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
                            var list = customerServices.GetAll();
                            display.Display_cus(list);
                            break;
                        }
                    case "5":
                        {
                            Console.Write("Customer's ID :");
                            int id = int.Parse(Console.ReadLine());
                            var result = customerServices.GetByID(id);
                            display.Display_cus1(result);
                            break;
                        }
                    case "6":
                        {
                            Console.Write("Customer's address :");
                            string address = Console.ReadLine();
                            var result = customerServices.GetByAddress(address);
                            display.Display_cus(result);
                            break;

                        }
                    case "7":
                        {
                            Console.Write("Customer's email :");
                            string email = Console.ReadLine();
                            var result = customerServices.GetByEmail(email);
                            display.Display_cus(result);
                            break;
                        }
                    case "8":
                        {
                            Console.Write("Customer's name :");
                            string name = Console.ReadLine();
                            var result = customerServices.GetByName(name);
                            display.Display_cus(result);
                            break;
                        }
                    case "9":
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

