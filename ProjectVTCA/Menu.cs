using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectVTCA
{
    public class Menu
    {
        public void Menu_Acc()
        {
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                           ACCOUNT MANAGE                                         ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           0. Exit                                                ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           1.Insert account                                       ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           2.Update account                                       ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           3.Delete account                                       ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           4.Show all account                                     ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           5.Search by username                                   ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           6.Search by employee's ID                              ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════════════════╝");
        }
        public void Menu_Employee()
        {
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                           EMPLOYEE MANAGE                                        ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           0. Exit                                                ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           1.Insert employee                                      ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           2.Update employee                                      ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           3.Delete employee                                      ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           4.Show all employee                                    ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           5.Search by employee's ID                              ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           6.Search by employee's address                         ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           7.Search by employee's age                             ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           8.Search by employee's email                           ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           9.Search by employee's name                            ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           10.Search by employee's phone                          ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════════════════╝");
        }
        public void Menu_KH()
        {
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                           CUSTOMER MANAGE                                        ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           0. Exit                                                ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           1.Insert customer                                      ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           2.Update customer                                      ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           3.Delete customer                                      ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           4.Show all customer                                    ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           5.Search by customer's ID                              ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           6.Search by customer's address                         ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           7.Search by customer's email                           ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           8.Search by customer's name                            ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           9.Search by customer's phone                           ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════════════════╝");
        }
        public void Menu_Cag()
        {
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                           CATEGORY MANAGE                                        ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           0. Exit                                                ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           1.Insert category                                      ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           2.Update category                                      ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           3.Delete category                                      ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           4.Show all category                                    ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════════════════╝");
        }
        public void Menu_Pro()
        {
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                           PRODUCT MANAGE                                         ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           0. Exit                                                ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           1.Insert product                                       ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           2.Update product                                       ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           3.Delete product                                       ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           4.Show all product                                     ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           5.Search by product's ID                               ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           6.Search by cag_id                                     ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           7.Search by dated_added                                ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           8.Search by name                                       ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           9.Search by price                                      ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           10.Search by description                               ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════════════════╝");
        }
        public void Menu_Bill()
        {
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                           INVOICE                                                ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           0. Exit                                                ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           1.Insert invoice                                       ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           2.Update invoice                                       ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           3.Delete invoice                                       ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           4.Show all invoice                                     ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           5.Search by ID                                         ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           6.View invoice details                                 ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           7.View by sale date                                    ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════════════════╝");
        }
        public void Menu_Tong()
        {
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           0. Exit                                                ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           1.Employees                                            ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           2.Accounts                                             ║");
            Console.WriteLine("╟                                                                                                  ╢");
            Console.WriteLine("║                                           3.Customers                                            ║");
            Console.WriteLine("╟                                                                                                  ╢");
            Console.WriteLine("║                                           4.Categories                                           ║");
            Console.WriteLine("╟                                                                                                  ╢");
            Console.WriteLine("║                                           5.Products                                             ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           6.Bills                                                ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════════════════╝");
        }
        public void Menu_Emp()
        {

            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                   ╦═══╗  ╔══╦══╗  ╔══╗  ╦    ╔═══╗  ╦   ╦  ╦═══╗  ╦═══╗  ╔═══╗                   ║");
            Console.WriteLine("║                   ╠══    ║  ╩  ║  ╠══╝  ║    ║   ║  ╚═╦═╝  ╠══    ╠══    ╚═══╗                   ║");
            Console.WriteLine("║                   ╩═══╝  ╩     ╩  ╩     ╚══╝ ╚═══╝    ╩    ╩═══╝  ╩═══╝  ╚═══╝                   ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           0. Exit                                                ║");
            Console.WriteLine("╟                                                                                                  ╢");
            Console.WriteLine("║                                           1.Categories                                           ║");
            Console.WriteLine("╟                                                                                                  ╢");
            Console.WriteLine("║                                           2.Products                                             ║");
            Console.WriteLine("╟                                                                                                  ╢");
            Console.WriteLine("║                                           3.Customers                                            ║");
            Console.WriteLine("╟                                                                                                  ╢");
            Console.WriteLine("║                                           4.Bills                                                ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════════════════╝");
        } 
       public void Menu_Log()
        {
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║          ╔══╗ ╦   ╦ ╔═══╗  ╔═══╗  ╦═══╗      ╔═══╗  ╔══╦══╗  ╔═══╗  ╦═══╗  ╦═══╗                 ║");
            Console.WriteLine("║          ╠══╝ ╬═══╬ ║   ║  ║   ║  ╠══        ╚═══╗     ║     ║   ║  ╠══╦╝  ╠══                   ║");
            Console.WriteLine("║          ╩    ╩   ╩ ╚═══╝  ╩   ╩  ╩═══╝      ╚═══╝     ╩     ╚═══╝  ╩  ╩═  ╩═══╝                 ║");
            Console.WriteLine("║                                          [LOGIN]                                                 ║");
            Console.WriteLine("╟──────────────────────────────────────────────────────────────────────────────────────────────────╢");
            Console.WriteLine("║                                           0. Exit                                                ║");
            Console.WriteLine("╟──────────────────────────────────────────────────────────────────────────────────────────────────╢");
            Console.WriteLine("║                                           1. Enter Account                                       ║");
            Console.WriteLine("╟──────────────────────────────────────────────────────────────────────────────────────────────────╢");
            Console.WriteLine("║                                           2. Customer                                            ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════════════════╝");
        }
        public void Menu_Cus()
        {
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                      ╔═══╗  ╦   ╦  ╔═══╗  ╔══╦══╗  ╔═══╗  ╔══╦══╗  ╦═══╗  ╦═══╗                  ║");
            Console.WriteLine("║                      ║      ║   ║  ╚═══╗     ║     ║   ║  ║  ╩  ║  ╠══    ╠══╦╝                  ║");
            Console.WriteLine("║                      ╚═══╝  ╚═══╝  ╚═══╝     ╩     ╚═══╝  ╩     ╩  ╩═══╝  ╩  ╩═                  ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           0.Exit                                                 ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           1.Show All Categories                                  ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           2.Show All Products                                    ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           3.Search By Product's ID                               ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           4.Search By Category ID                                ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           5.Search By Dated Added                                ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           6.Search By Name                                       ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           7.Search By Price                                      ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           8.Search By Description                                ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════════════════╝");
        }
        public void Menu_Admin()
        {
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                        ╔══╦══╗  ╔═══╗  ╔═══╗  ╔═══╗  ╔═══╗   ╦═══╗  ╦═══╗                        ║");
            Console.WriteLine("║                        ║  ╩  ║  ╬═══╬  ║   ║  ╬═══╬  ║  ═╦═  ╠══    ╠══╦╝                        ║");
            Console.WriteLine("║                        ╩     ╩  ╩   ╩  ╩   ╩  ╩   ╩  ╚═══╝   ╩═══╝  ╩  ╩═                        ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           0.Exit                                                 ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           1.Employees                                            ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           2.Accounts                                             ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           3.Categories                                           ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           4.Products                                             ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           5.View Customer                                        ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           6.View Bills                                           ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════════════════╝");
        }
        public void View_Cus()
        {
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           0.Exit                                                 ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           1.Show all customer                                    ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           2.Search by customer's ID                              ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           3.Search by customer's address                         ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           4.Search by customer's email                           ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           5.Search by customer's name                            ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           6.Search by customer's phone                           ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════════════════╝");
        }
        public void View_Bill() {
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           0.Exit                                                 ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           1.List Of Bills                                        ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           2.Search By Bill ID                                    ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           3.View Bill Infomation                                 ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           4.Tim hoa don theo ngay                                ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════════════════╝");
        }
        public void EmpCag_View()
        {
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                           CATEGORY MANAGE                                        ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           0. Exit                                                ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           1.Show all category                                    ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════════════════╝");
        }
        public void EmpPro_View()
        {
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                           PRODUCT MANAGE                                         ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           0. Exit                                                ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           1.Show all product                                     ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           2.Search by product's ID                               ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           3.Search by cag_id                                     ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           4.Search by dated_added                                ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           5.Search by name                                       ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           6.Search by price                                      ║");
            Console.WriteLine("║                                                                                                  ║");
            Console.WriteLine("║                                           7.Search by description                                ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════════════════╝");
        }
    }
}
