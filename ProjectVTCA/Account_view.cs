using BL.Implement;
using DAL.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectVTCA
{
    public class Account_view
    {
        public void Acc_view(AccountServices accountServices , EmployeeServices employeeServices1)
        {
            string chon;
            Menu menu = new Menu();
            Display display = new Display();

            do
            {
                menu.Menu_Acc();
                Console.Write("->Enter Your Choice:");
                chon = Console.ReadLine();
                switch (chon)
                {
                    case "0":
                        {
                            break;
                        }
                    case "1":
                        {
                            Accounts acc= new Accounts();
                            Console.WriteLine("ENTER YOUR INFORMATION!!");
                            Console.Write("->User name: ");
                            acc.username = Console.ReadLine();
                            Console.Write("->Password: ");
                            acc.password = Console.ReadLine();
                            bool accvalid = false;
                            bool empvalid = false;
                            do
                            {
                                display.Display_emp(employeeServices1.GetAll());
                                Console.Write("->Employee's ID: ");
                                int Employee_ID = int.Parse(Console.ReadLine());

                                var resultn = accountServices.GetByEmployeeID(Employee_ID);
                                var resulte = employeeServices1.GetByID(Employee_ID);
                                if (resultn == null && resulte != null)
                                {
                                    accvalid = true;
                                    acc.Employee_ID= Employee_ID;
                                } else
                                {
                                    Console.WriteLine("Employee ID has been used !");      
                                }
                            } while (!accvalid);
                            bool per_valid = false;
                            string permission;
                            do
                            {
                                Console.Write("->Permission (0 or 1): ");
                                permission = Console.ReadLine();
                                if (permission == "0" || permission == "1")
                                {
                                    per_valid = true;
                                    acc.Permission = int.Parse(permission);
                                }
                                else
                                {
                                    per_valid = false;
                                    Console.WriteLine("Invalid input! Please enter 0 or 1.");
                                }
                            } while (!per_valid);

                            acc.status = 1;
                            var result = accountServices.Insert(acc);
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
                            Console.WriteLine("Enter account's information need to be updated!");
                            Console.Write("->User Name: ");
                            string username = Console.ReadLine();
                            var result = accountServices.GetByUserName(username);
                            if (result == null)
                            {
                                Console.WriteLine("Account not found!");
                            }
                            else
                            {
                                Console.WriteLine("Enter User Infomation !");
                                Console.Write("->Password: ");
                                result.password = Console.ReadLine();
                                result.Employee_ID = result.Employee_ID;
                                bool per_valid = false;
                                string permission;
                                do
                                {
                                    Console.Write("->Permission (0 or 1): ");
                                    permission = Console.ReadLine();
                                    if (permission == "0" || permission == "1")
                                    {
                                        per_valid = true;
                                        result.Permission = int.Parse(permission);
                                    }
                                    else
                                    {
                                        per_valid = false;
                                        Console.WriteLine("Invalid input! Please enter 0 or 1.");
                                    }
                                } while (!per_valid);
                                result.status = 1;
                                var result1 = accountServices.Update(result, username);
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
                            Console.WriteLine("Enter account's user name need to be deleted!");
                            Console.Write("->Enter username : ");
                            string username = Console.ReadLine();
                            var result = accountServices.GetByUserName(username);
                            if (result == null)
                            {
                                Console.WriteLine("This account has not been existed!");
                            }
                            else
                            {
                                var result1 = accountServices.Delete(username);
                                var resultx = employeeServices1.Delete(result.Employee_ID);
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
                            Console.WriteLine("List all account");
                            var result = accountServices.GetAll();
                            display.Display_acc(result , employeeServices1);
                            break;
                        }
                    case "5":
                        {
                            Console.Write("->User name: ");
                            string username = Console.ReadLine();
                            var result = accountServices.GetByUserName(username);
                            display.Display_acc1(result , employeeServices1);
                            break;
                        }
                    case "6":
                        {
                            Console.Write("->Employee's ID: ");
                            int id = int.Parse(Console.ReadLine());
                            var result = accountServices.GetByEmployeeID(id);
                            display.Display_acc1(result , employeeServices1);
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

