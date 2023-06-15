using BL.Implement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DBContext;
using BL.Interfaces;
using MySqlX.XDevAPI.Common;
using System.Runtime.InteropServices;

namespace ProjectVTCA
{
    public class Login
    {
        public void LogAcc(AccountServices accountServices)
        {
            Account_view account_View = new Account_view();
            Category_view category_View = new Category_view();
            Product_view product_View = new Product_view();
            Employee_view employee_View = new Employee_view();
            Customer_view customer_View = new Customer_view();
            BillInfoService billInfoService = new BillInfoService();
            Bill_view bill_view = new Bill_view();
            CustomerServices customerServices = new CustomerServices();
            CategoryService categoryService = new CategoryService();
            ProductService productService = new ProductService();
            EmployeeServices employeeServices = new EmployeeServices();
            BillService billService = new BillService();
            Menu menu1 = new Menu();
            View_BillAD view_BillAD = new View_BillAD();
            Customer_ViewAD viewcusAD = new Customer_ViewAD();
            string luachon;
            do
            {
                //menu1.Menu_Log();
                Console.Write("-> Enter User Name : ");
                string username = Console.ReadLine();
                var result1 = accountServices.GetByUserName(username);
                if (result1 == null)
                {
                    Console.WriteLine("User Name not found!");
                }
                else
                {
                    Console.Write("-> Enter Pass Word: ");
                    string password = Console.ReadLine();
                    var result2 = accountServices.GetByUserName(username);
                    if (result2.password != password)
                    {
                        Console.WriteLine("Pass Word not found!");
                    }
                    else
                    {
                        var result4 = accountServices.GetByUserName(username);
                        if (result4.Permission == 1)
                        {
                            string chon;
                            do
                            {
                                menu1.Menu_Admin();
                                Console.Write("Enter your choice: ");
                                chon = Console.ReadLine();
                                switch (chon)
                                {
                                    case "0":
                                        {
                                            Console.WriteLine("Da Thoat Chuong Trinh");
                                            break;
                                        }
                                    case "1":
                                        {
                                            employee_View.Emp_view(employeeServices , accountServices);
                                            break;
                                        }
                                    case "2":
                                        {
                                            account_View.Acc_view(accountServices, employeeServices);
                                            break;
                                        }
                                    case "3":
                                        {

                                            category_View.Cag_view(categoryService);
                                            break;
                                        }
                                    case "4":
                                        {
                                            product_View.Pro_view(productService, categoryService);
                                            break;
                                        }
                                    case "5":
                                        {
                                            viewcusAD.View_Cus(customerServices);
                                            break;
                                        }
                                    case "6":
                                        {
                                            view_BillAD.View_Bill(username, billService , productService , billInfoService , accountServices,employeeServices ,customerServices ,categoryService);
                                            break;
                                        }
                                    default:
                                        break;
                                }
                            } while (chon != "0");
                        }
                        else if (result4.Permission == 0)
                        {
                            string chon2;
                            do
                            {
                                menu1.Menu_Emp();
                                Console.Write("Enter your choice: ");
                                chon2 = Console.ReadLine();
                                switch (chon2)
                                {
                                    case "0":
                                        {
                                            Console.WriteLine("Da Thoat Chuong Trinh");
                                            break;
                                        }
                                    case "1":
                                        {
                                            employee_View.EmpView_Cag(categoryService);
                                            break;
                                        }
                                    case "2"://pro
                                        {
                                            employee_View.EmpPro_View(productService , categoryService);
                                            break;
                                        }
                                    case "3": //customer
                                        {
                                            customer_View.Cus_view(customerServices);
                                            break;
                                        }
                                    case "4"://bill
                                        {
                                            bill_view.bill_View(username ,billService, productService, billInfoService, accountServices, employeeServices, customerServices, categoryService);
                                            break;
                                        }
                                    default:
                                        break;
                                }
                            } while (chon2 != "0");
                        }
                    }
                }
                    Console.Write("Nhap tai khoan khac (co(bam 0)/khong(bam bat ki)):");
                    luachon = Console.ReadLine();
                } while (luachon == "0");
            }
    }
}
