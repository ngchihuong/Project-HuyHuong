using BL.Implement;
using DAL.DBContext;
using ProjectVTCA;
using System.Collections.Generic;

Account_view account_View = new Account_view();
Category_view category_View = new Category_view();
Product_view product_View = new Product_view();
Employee_view employee_View = new Employee_view();
Customer_view customer_View = new Customer_view();
BillInfoService billInfoService= new BillInfoService();
Bill_view bill_view = new Bill_view();
Menu menu = new Menu();
AccountServices accountServices = new AccountServices();
CustomerServices customerServices = new CustomerServices();
CategoryService categoryService = new CategoryService();
ProductService productService = new ProductService();
EmployeeServices employeeServices = new EmployeeServices();
BillService billService = new BillService();
Login login= new Login();
Display display = new Display();
CustomerLogin cuslog = new CustomerLogin();
string chon;
do
{
    menu.Menu_Log();
    Console.Write("-> Enter your choice: ");
    chon = Console.ReadLine();
    switch (chon)
    {
        case "0":
            {
                Console.WriteLine("Thoat!");
                break;
            }
        case "1":  //account
            {
                Console.WriteLine("Ban dang trong chuc nang quan li !");
                login.LogAcc(accountServices);
                break;
            }
        case "2": //khach hang
            {
                cuslog.CusLog(categoryService, productService);
                break;
            }
        default:
            break;
    }
} while (chon != "0");
