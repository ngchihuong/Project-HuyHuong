using BL.Implement;
using DAL.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectVTCA
{
    public class View_BillAD
    {
        public void View_Bill(string username, BillService billServices, ProductService proServices, BillInfoService billinfoServices, AccountServices accountServices1, EmployeeServices employeeServices1, CustomerServices customerServices1, CategoryService cagsv)
        {
            string chon ;
            Menu menu = new Menu();
            Display display = new Display();
            do
            {
                menu.View_Bill();

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
                            var list = billServices.GetAll();
                            display.Display_Bill(list, accountServices1, employeeServices1, customerServices1);
                            break;
                        }
                    case "2":
                        {
                            Console.Write("ID:");
                            int id = int.Parse(Console.ReadLine());
                            var result = billServices.GetByID(id);
                            display.Display_Bill1(result, accountServices1, employeeServices1, customerServices1);
                            break;
                        }
                    case "3":
                        {
                            Console.Write("ID:");
                            int id = int.Parse(Console.ReadLine());
                            var list = billinfoServices.GetByBill_ID(id);
                            display.Display_Billinfor(list, proServices);
                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine("Enter first date");
                            int date1 = 0;
                            int month1 = 0;
                            int year1 = 0;

                            Console.Write("Year: ");
                            year1 = int.Parse(Console.ReadLine());

                            Console.Write("Month: ");
                            month1 = int.Parse(Console.ReadLine());

                            bool validDate1 = false;
                            do
                            {
                                Console.Write("Date: ");
                                date1 = int.Parse(Console.ReadLine());

                                if (date1 >= 1 && date1 <= DateTime.DaysInMonth(year1, month1))
                                {
                                    validDate1 = true;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid date!");
                                }
                            } while (!validDate1);

                            DateTime firstDate = new DateTime(year1, month1, date1);

                            Console.WriteLine("Enter last date");
                            int date2 = 0;
                            int month2 = 0;
                            int year2 = 0;

                            bool validYear2 = false;
                            do
                            {
                                Console.Write("Year: ");
                                year2 = int.Parse(Console.ReadLine());

                                if (year2 >= firstDate.Year)
                                {
                                    validYear2 = true;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid year!");
                                }
                            } while (!validYear2);

                            bool validMonth2 = false;
                            do
                            {
                                Console.Write("Month: ");
                                month2 = int.Parse(Console.ReadLine());

                                if ((year2 > firstDate.Year && month2 >= 1 && month2 <= 12) ||
                                    (year2 == firstDate.Year && month2 >= firstDate.Month))
                                {
                                    validMonth2 = true;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid month!");
                                }
                            } while (!validMonth2);

                            bool validDate2 = false;
                            do
                            {
                                Console.Write("Date: ");
                                date2 = int.Parse(Console.ReadLine());

                                if (year2 > firstDate.Year || (year2 == firstDate.Year && month2 > firstDate.Month))
                                {
                                    if (date2 >= 1 && date2 <= DateTime.DaysInMonth(year2, month2))
                                    {
                                        validDate2 = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid date!");
                                    }
                                }
                                else if (year2 == firstDate.Year && month2 == firstDate.Month)
                                {
                                    if (date2 >= firstDate.Day && date2 <= DateTime.DaysInMonth(year2, month2))
                                    {
                                        validDate2 = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid date!");
                                    }
                                }
                            } while (!validDate2);

                            DateTime lastDate = new DateTime(year2, month2, date2);

                            var list = billServices.GetBySaleDated(firstDate, lastDate);
                            display.Display_Bill(list, accountServices1, employeeServices1, customerServices1);
                            Console.WriteLine("Show total earning?(0)");
                            string show = Console.ReadLine();
                            decimal total = 0;
                            if (show == "0")
                            {
                                display.Display_Bill(list, accountServices1, employeeServices1, customerServices1);
                                foreach (var item in list)
                                {
                                    total += item.total_Price;
                                }
                                Console.WriteLine("Total :{0}", total);
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("error!!");
                            Console.WriteLine("--------------------------");
                            break;
                        }
                }
            } while (chon != "0");
        }
    }
}