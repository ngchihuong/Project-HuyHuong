using BL.Implement;
using BL.Interfaces;
using DAL.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProjectVTCA
{
    public class Bill_view
    {
        public void bill_View( string username ,BillService billServices, ProductService proServices, BillInfoService billinfoServices, AccountServices accountServices1, EmployeeServices employeeServices1, CustomerServices customerServices1, CategoryService cagsv) 
        {
            string chon ;
            Menu menu = new Menu();
            Display display = new Display();
            do
            {
                menu.Menu_Bill();

                Console.Write("->Enter Your Choice :");
                chon = Console.ReadLine();
                switch (chon)
                {
                    case "0":
                        {
                            break;
                        }
                    case "1":
                        {
                            //Console.Write("ID: ");
                            //bill.Bill_ID = int.Parse(Console.ReadLine());
                            var bis = new Bill();
                            bis.Sale_Date = DateTime.Now;
                            bis.username = username;
                            bis.total_Price = 0;
                            bool cus_valid = false;
                            display.Display_cus(customerServices1.GetAll()); 
                            do
                            {
                                Console.Write("->Customer Id:");
                                int cus_id = int.Parse(Console.ReadLine());
                                if (customerServices1.GetByID(cus_id) != null)
                                {
                                    cus_valid = true;
                                    bis.Cus_ID = cus_id;
                                }
                                else
                                {
                                    Console.WriteLine("Customer not exist!");
                                }
                            } while (!cus_valid);
                            decimal total_Price1 = 0;
                            bis.status = 1;
                            billServices.Insert(bis);
                            string yes;
                            do
                            {
                                display.Display_pro(proServices.GetAll(), cagsv);
                                BillInfo billInfo = new BillInfo();
                                billInfo.Bill_ID = bis.Bill_ID;
                                
                                Products productResult = null;
                                do
                                {
                                    try
                                    {
                                        Console.Write("->Choose a product ID to add to bill: ");
                                        int productID = int.Parse(Console.ReadLine());
                                        productResult = proServices.GetByID(productID);
                                        billInfo.Pro_ID = productID;
                                    }
                                    catch (Exception )
                                    {
                                        Console.WriteLine("ID invalid!");
                                    }
                                    
                                } while (productResult == null);
                                bool quantity_valid = false;
                                string quantity;
                                do
                                {
                                    Console.Write("->Quantity : ");
                                    quantity = Console.ReadLine();
                                    quantity_valid = true;
                                    if (quantity.StartsWith('0'))
                                    {
                                        quantity_valid = false;
                                        Console.WriteLine("Quantity invalid!!!(Need enter quantity more than 0)");
                                    }
                                    else
                                    {
                                        foreach (var num in quantity)
                                        {
                                            if (!char.IsDigit(num))
                                            {
                                                quantity_valid = false;
                                                Console.WriteLine("Quantity invalid!!(Quantity just include number)");
                                                break; 
                                            }
                                            if (!quantity_valid)
                                            {
                                                Console.WriteLine("Quantity invalid!!(Quantity just include number)");
                                            }
                                        }
                                        if (quantity_valid) 
                                        {
                                            billInfo.quantity = int.Parse(quantity);
                                            var kq = billInfo.quantity;
                                            if (kq <= productResult.Quantity)
                                            {
                                                quantity_valid = true;
                                            }
                                            else
                                            {
                                                quantity_valid= false;
                                                Console.WriteLine("Out of stock");
                                            }
                                        }
                                    }
                                } while (quantity_valid == false);
                                var Unit_Price = productResult.Price;
                                billInfo.status = 1;
                                billinfoServices.Insert(billInfo);
                                total_Price1 += Unit_Price * billInfo.quantity;
                                bis.total_Price = total_Price1;
                                billServices.Update(bis, bis.Bill_ID);
                                if (billServices.Update(bis, bis.Bill_ID) == 1)
                                {
                                    Console.WriteLine("Insert Succeed");
                                }
                                else
                                {
                                    Console.WriteLine("Insert False");
                                }

                                Console.Write("->Nhap them san pham(co(bam 0)/khong(bam bat ki)):");
                                yes = Console.ReadLine();
                            } while (yes == "0");
                            var list = billServices.GetAll();
                            display.Display_Bill(list, accountServices1, employeeServices1, customerServices1);
                            break;
                        }
                    case "2":
                        {
                            var list1 = billServices.GetAll();
                            display.Display_Bill(list1, accountServices1, employeeServices1, customerServices1);
                            Console.Write("->Nhap ID can sua:");
                            int id = int.Parse(Console.ReadLine());
                            decimal totalPrice = 0;
                            var ex_bi = billServices.GetByID(id);
                            string yes;
                            if (ex_bi != null)
                            {
                                //bill.Bill_ID = int.Parse(Console.ReadLine());

                                bool cus_valid = false;
                                display.Display_cus(customerServices1.GetAll()); do
                                {
                                    Console.Write("->Customer Id:");
                                    int cus_id = int.Parse(Console.ReadLine());
                                    if (customerServices1.GetByID(cus_id) != null)
                                    {
                                        cus_valid = true;
                                        ex_bi.Cus_ID = cus_id;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Customer not exist!");
                                    }
                                } while (!cus_valid);
                                var bill_ex = billinfoServices.GetByBill_ID(ex_bi.Bill_ID);
                                foreach (var ex in bill_ex)
                                {
                                    ex.status = 0;
                                }
                                do
                                {
                                    BillInfo new_billi = new BillInfo();
                                    Products pro = null;
                                    new_billi.Bill_ID = ex_bi.Bill_ID;
                                    do
                                    {
                                        Console.Write("->ID product:");
                                        int id_pro = int.Parse(Console.ReadLine());
                                        pro = proServices.GetByID(id_pro);
                                        if (pro != null)
                                        {
                                            new_billi.Pro_ID = pro.Pro_ID;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Product not exist!");
                                        }
                                    } while (pro == null);
                                    bool quantity_valid = false;
                                    string quantity;
                                    do
                                    {
                                        Console.Write("->Quantity: ");
                                        quantity = Console.ReadLine();
                                        quantity_valid = true;
                                        if (quantity.StartsWith('0'))
                                        {
                                            quantity_valid = false;
                                            Console.WriteLine("Quantity invalid!!!(Need enter quantity more than 0)");
                                        }
                                        else
                                        {
                                            foreach (var num in quantity)
                                            {
                                                if (!char.IsDigit(num))
                                                {
                                                    quantity_valid = false;
                                                    Console.WriteLine("Quantity number invalid!!(Quantity just include number)");
                                                    break;
                                                }
                                                if (!quantity_valid)
                                                {
                                                    Console.WriteLine("Quantity invalid!!(Quanity just include number)");
                                                }
                                            }
                                            if (quantity_valid)
                                            {
                                                new_billi.quantity = int.Parse(quantity);
                                                var kq = new_billi.quantity;
                                                if (kq <= pro.Quantity)
                                                {
                                                    quantity_valid = true;
                                                }
                                                else
                                                {
                                                    quantity_valid = false;
                                                    Console.WriteLine("Out of stock");
                                                }
                                            }
                                        }
                                    } while (quantity_valid == false);
                                    new_billi.status = 1;
                                    billinfoServices.Insert(new_billi);
                                    totalPrice += new_billi.quantity * pro.Price;
                                    ex_bi.total_Price = totalPrice;
                                    billServices.Update(ex_bi, id);
                                    Console.Write("->Nhap them san pham(co(bam 0)/khong(bam bat ki)):");
                                    yes = Console.ReadLine();
                                } while (yes == "0");
                                var list = billServices.GetAll();
                                display.Display_Bill(list, accountServices1, employeeServices1, customerServices1);
                            }
                            else
                            {
                                Console.WriteLine("Bill not found!");
                            }

                            break;
                        }
                    case "3":
                        {
                            var list1 = billServices.GetAll();
                            display.Display_Bill(list1, accountServices1, employeeServices1, customerServices1);
                            Console.Write("->Id can xoa:");
                            int id = int.Parse(Console.ReadLine());
                            var list = billinfoServices.GetByBill_ID(id);
                            foreach (var item in list)
                            {
                                billinfoServices.Delete(item.Bill_Info_ID);
                            }
                            var result = billServices.Delete(id);
                            if (result > 0)
                            {
                                Console.WriteLine("thanh cong!!!");
                            }
                            else
                            {
                                Console.WriteLine("that bai!!!");
                            }
                            break;
                        }
                    case "4":
                        {
                            var list = billServices.GetAll();
                            display.Display_Bill(list, accountServices1, employeeServices1, customerServices1);
                            break;
                        }
                    case "5":
                        {
                            Console.Write("->ID:");
                            int id = int.Parse(Console.ReadLine());
                            var result = billServices.GetByID(id);
                            display.Display_Bill1(result, accountServices1, employeeServices1, customerServices1);
                            break;
                        }
                    case "6":
                        {
                            Console.Write("->ID:");
                            int id = int.Parse(Console.ReadLine());
                            var list = billinfoServices.GetByBill_ID(id);
                            display.Display_Billinfor(list, proServices);
                            break;
                        }
                    case "7":
                        {
                            Console.WriteLine("Enter first date");
                            int date1 = 0;
                            int month1 = 0;
                            int year1 = 0;

                            Console.Write("->Year: ");
                            year1 = int.Parse(Console.ReadLine());

                            Console.Write("->Month: ");
                            month1 = int.Parse(Console.ReadLine());

                            bool validDate1 = false;
                            do
                            {
                                Console.Write("->Date: ");
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
                                Console.Write("->Year: ");
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
                            Console.WriteLine("ERROR!!");
                            break;
                        }
                }
            } while (chon != "0");
        }
    }
}