using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Implement;
using DAL.DBContext;
using Google.Protobuf.WellKnownTypes;

namespace ProjectVTCA
{
    public class Display
    {
        public void Display_acc(List<Accounts> list, EmployeeServices empsv)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("╔═════════════════════════════════════════════════╗");
                Console.WriteLine("║                 Empty!                          ║");
                Console.WriteLine("╚═════════════════════════════════════════════════╝");
            }
            else
            {
                Console.WriteLine("╔═════════════════════════════════════════════════╗");
                Console.WriteLine("║User Name       ║Password       ║Nhan Vien       ║");
                foreach (var acc in list)
                {
                    var emp = empsv.GetByID(acc.Employee_ID);
                    Console.WriteLine($"║{acc.username,-16}║{acc.password,-15}║{emp.Employee_Name,-16}║");
                }
                Console.WriteLine("╚═════════════════════════════════════════════════╝");
            }
        }
        public void Display_acc1(Accounts acc, EmployeeServices empsv)
        {
            if (acc == null)
            {
                Console.WriteLine("╔═════════════════════════════════════════════════╗");
                Console.WriteLine("║                 Empty!                          ║");
                Console.WriteLine("╚═════════════════════════════════════════════════╝");
            }
            else
            {
                Console.WriteLine("╔═════════════════════════════════════════════════╗");
                Console.WriteLine("║User Name       ║Password       ║Nhan Vien       ║");
                var emp = empsv.GetByID(acc.Employee_ID);
                Console.WriteLine($"║{acc.username,-16}║{acc.password,-15}║{emp.Employee_Name,-16}║");
            }
                Console.WriteLine("╚═════════════════════════════════════════════════╝");
        }
        public void Display_emp(List<Employees> list)
        {
            if (!list.Any())
            {
                Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║                                            Empty!                                                ║");
                Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════════════════╝");
            }
            else
            {
                Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║ID       ║Employee Name       ║Age        ║Phone Number   ║Address       ║Email                    ║");
                foreach (var emp in list)
                {
                    Console.WriteLine($"║{emp.Employee_ID,-9}║{emp.Employee_Name,-20}║{emp.Age,-11}║{emp.Phone_Number,-15}║{emp.Address,-14}║{emp.Email,-25}║");
                }
                Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════════════════════════════════╝");
            }
        }
        public void Display_emp1(Employees emp)
        {
            if (emp == null)
            {
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║                                                Empty!                                              ║");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            }
            else
            {
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║ID       ║Employee Name       ║Age        ║Phone Number   ║Address        ║Email                    ║");
                Console.WriteLine($"║{emp.Employee_ID,-9}║{emp.Employee_Name,-20}║{emp.Age,-11}║{emp.Phone_Number,-15}║{emp.Address,-15}║{emp.Email,-25}║");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            }

        }
        public void Display_cus(List<Customers> list)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║                                       Empty!                                        ║");
                Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════════╝");
            }
            else
            {
                Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║ID       ║Customer Name       ║Email                    ║Customer Phone ║Address     ║");
                foreach (var cus in list)
                {
                    Console.WriteLine($"║{cus.Cus_ID,-9}║{cus.Cus_Name,-20}║{cus.Email,-25}║{cus.Cus_Phone,-15}║{cus.Address,-12}║");
                }
                Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════════╝");
            }
        }
        public void Display_cus1(Customers cus)
        {
            if (cus == null)
            {
                Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║                                       Empty!                                        ║");
                Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════════╝");
            }
            else
            {
                Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║ID       ║Customer Name       ║Email                    ║Customer Phone ║Address     ║");

                Console.WriteLine($"║{cus.Cus_ID,-9}║{cus.Cus_Name,-20}║{cus.Email,-25}║{cus.Cus_Phone,-15}║{cus.Address,-12}║");
                Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════════╝");
            }
        }
        public void Display_cag(List<Categories> list)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("╔══════════════════════════════╗");
                Console.WriteLine("║           Empty!             ║");
                Console.WriteLine("╚══════════════════════════════╝");
            }
            else
            {
                Console.WriteLine("╔══════════════════════════════╗");
                Console.WriteLine("║ID       ║Category Name       ║");
                foreach (var cag in list)
                {
                    Console.WriteLine($"║{cag.Cag_ID,-9}║{cag.Cag_Name,-20}║");
                }
                Console.WriteLine("╚══════════════════════════════╝");
            }
        }
        public void Display_pro(List<Products> list, CategoryService cagsv)
        {

            if (!list.Any())
            {
                Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║                                                          Empty!                                                      ║");
                Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            }
            else
            {
                Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║ID       ║Product Name     ║Category    ║Date Added            ║Description   ║Price      ║Quantity  ║Product Brand   ║");
                foreach (var pro in list)
                {
                    var cag = cagsv.GetByID(pro.Cag_ID);
                    Console.WriteLine($"║{pro.Pro_ID,-9}║{pro.Pro_Name,-17}║{cag.Cag_Name,-12}║{pro.Date_Added,-22}║{pro.Description,-14}║{pro.Price,-11}║{pro.Quantity,-10}║{pro.Pro_Brand,-16}║");
                }
                Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            }
        }
        public void Display_pro1(Products pro, CategoryService cagsv)
        {
            if (pro == null)
            {
                Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║                                                          Empty!                                                      ║");
                Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            }
            else
            {
                var cag = cagsv.GetByID(pro.Cag_ID);
                Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║ID       ║Product Name     ║Category    ║Date Added            ║Description   ║Price      ║Quantity  ║Product Brand   ║");
                Console.WriteLine($"║{pro.Pro_ID,-9}║{pro.Pro_Name,-17}║{cag.Cag_Name,-12}║{pro.Date_Added,-22}║{pro.Description,-14}║{pro.Price,-11}║{pro.Quantity,-10}║{pro.Pro_Brand,-16}║");
                Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            }
        }
        public void Display_Bill(List<Bill> list, AccountServices accsv, EmployeeServices empsv, CustomerServices cussv)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║                                         Empty!                                    ║");
                Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════════════════╝");
            }
            else
            {
                Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║ID       ║Employee Name       ║Sale Date              ║Total Price    ║Customer            ║");
                foreach (var bill in list)
                {
                    var acc = accsv.GetByUserName(bill.username);
                    var emp = empsv.GetByID(acc.Employee_ID);
                    var cus = cussv.GetByID(bill.Cus_ID);
                    Console.WriteLine($"║{bill.Bill_ID,-9}║{emp.Employee_Name,-20}║{bill.Sale_Date,-23}║{bill.total_Price,-15}║{cus.Cus_Name,-20}║");
                }
                Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════════════════════════╝");

            }
        }
        public void Display_Bill1(Bill bill, AccountServices accsv, EmployeeServices empsv, CustomerServices cussv)
        {
            if (bill == null)
            {
                Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║                                         Empty!                                    ║");
                Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════════════════╝");
            }
            else
            {
                var acc = accsv.GetByUserName(bill.username);
                var emp = empsv.GetByID(acc.Employee_ID);
                var cus = cussv.GetByID(bill.Cus_ID);
                Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║ID       ║Employee Name       ║Sale Date              ║Total Price    ║Customer            ║");
                Console.WriteLine($"║{bill.Bill_ID,-9}║{emp.Employee_Name,-20}║{bill.Sale_Date,-23}║{bill.total_Price,-15}║{cus.Cus_Name,-20}║");
                Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════════════════════════╝");

            }
        }
        public void Display_Billinfor(List<BillInfo> list, ProductService prosv)
        {
            if (!list.Any())
            {
                Console.WriteLine("╔════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║                            Empty!                          ║");
                Console.WriteLine("╚════════════════════════════════════════════════════════════╝");
            }
            else
            {
                Console.WriteLine("╔════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║ID       ║Bill ID      ║Product             ║Quantity       ║");
                foreach (var billin in list)
                {
                    var pro = prosv.GetByID(billin.Pro_ID);
                    Console.WriteLine($"║{billin.Bill_Info_ID,-9}║{billin.Bill_ID,-13}║{pro.Pro_Name,-20}║{billin.quantity,-15}║");
                }
                Console.WriteLine("╚════════════════════════════════════════════════════════════╝");
            }
        }
    }
}