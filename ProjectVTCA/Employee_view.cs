using BL.Implement;
using DAL.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectVTCA
{
    public class Employee_view
    {
        public void Emp_view(EmployeeServices empServices , AccountServices accountServices )
        {
            string chon;
            Employees emp = new Employees();
            Menu menu = new Menu();
            Display display = new Display();
            do
            {
                menu.Menu_Employee();
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
                            //Console.Write("Employee'S ID: ");
                            //emp.Employee_ID = int.Parse(Console.ReadLine());
                            Console.Write("Employee's name: ");
                            emp.Employee_Name = Console.ReadLine();
                            int age;
                            bool isValid = false;
                            do
                            {
                                Console.Write("Enter your age: ");
                                string input = Console.ReadLine();

                                isValid = int.TryParse(input, out age);

                                if (!isValid)
                                {
                                    Console.WriteLine("Invalid input! Please enter a valid integer.");
                                }
                                else if (age < 18)
                                {
                                    Console.WriteLine("You must be at least 18 years old to use this service.");
                                    isValid = false;
                                }
                            } while (!isValid);

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

                            emp.Phone_Number = phone;
                            Console.Write("Address: ");
                            emp.Address = Console.ReadLine();
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
                            emp.Email = email;
                            emp.status = 1;
                            var result = empServices.Insert(emp);
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
                            Console.WriteLine("Enter employee's information need to be updated!");
                            Console.Write("Enter ID: ");
                            int id = int.Parse(Console.ReadLine());
                            var result = empServices.GetByID(id);
                            if (result == null)
                            {
                                Console.WriteLine("Employee not found!");
                            }
                            else
                            {
                                //Console.Write("Employee'S ID: ");
                                //emp.Employee_ID = int.Parse(Console.ReadLine());
                                Console.Write("Employee's name: ");
                                emp.Employee_Name = Console.ReadLine();

                                int age;
                                bool isValid = false;
                                do
                                {
                                    Console.Write("Enter your age: ");
                                    string input = Console.ReadLine();

                                    isValid = int.TryParse(input, out age);

                                    if (!isValid)
                                    {
                                        Console.WriteLine("Invalid input! Please enter a valid integer.");
                                    }
                                    else if (age < 18)
                                    {
                                        Console.WriteLine("You must be at least 18 years old to use this service.");
                                        isValid = false;
                                    }
                                } while (!isValid);

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

                                emp.Phone_Number = phone;
                                Console.Write("Address: ");
                                emp.Address = Console.ReadLine();
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
                                emp.Email = email;
                                emp.status = 1;
                                var result1 = empServices.Update(emp, id);
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
                            Console.WriteLine("Employee's ID: ");
                            int id = int.Parse(Console.ReadLine());
                            var result = empServices.GetByID(id);
                            if (result == null)
                            {
                                Console.WriteLine("Employee not found!");
                            }
                            else
                            {
                                var result1 = empServices.Delete(id);
                                var resultx = accountServices.GetByEmployeeID(id);
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
                            var list = empServices.GetAll();
                            display.Display_emp(list);
                            break;
                        }
                    case "5":
                        {
                            Console.Write("Employee's ID :");
                            int id = int.Parse(Console.ReadLine());
                            var result = empServices.GetByID(id);
                            display.Display_emp1(result);
                            break;
                        }
                    case "6":
                        {
                            Console.Write("Employee's address :");
                            string address = Console.ReadLine();
                            var result = empServices.GetByAddress(address);
                            display.Display_emp(result);
                            break;

                        }
                    case "7":
                        {

                            Console.Write("Employee's age :");
                            int age = int.Parse(Console.ReadLine()); ;
                            var result = empServices.GetByAge(age);
                            display.Display_emp(result);
                            break;
                        }
                    case "8":
                        {
                            Console.Write("Employee's email :");
                            string email = Console.ReadLine();
                            var result = empServices.GetByEmail(email);
                            display.Display_emp(result);
                            break;
                        }
                    case "9":
                        {
                            Console.Write("Employee's name :");
                            string name = Console.ReadLine();
                            var result = empServices.GetByName(name);
                            display.Display_emp(result);
                            Console.WriteLine("-----------------------------------------");
                            break;
                        }
                    case "10":
                        {
                            Console.Write("Employee's phone number :");
                            string phone = Console.ReadLine();
                            var result = empServices.GetByPhone(phone);
                            display.Display_emp(result);
                            Console.WriteLine("-----------------------------------------");
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
        public void EmpView_Cag(CategoryService cagService)
        {
            string chon ;
            Categories cag = new Categories();
            Menu menu = new Menu();
            Display display = new Display();
            do
            {
                menu.EmpCag_View();
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
                            var list = cagService.GetAll();
                            display.Display_cag(list);
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
        public void EmpPro_View(ProductService proService, CategoryService cagService)
        {
            string chon ;
            Products products = new Products();
            Menu menu = new Menu();
            Display display = new Display();
            do
            {
                menu.EmpPro_View();
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
                            var list = proService.GetAll();
                            display.Display_pro(list, cagService);
                            break;
                        }
                    case "2":
                        {
                            Console.Write("Product's ID :");
                            int id = int.Parse(Console.ReadLine());
                            var result = proService.GetByID(id);
                            display.Display_pro1(result, cagService);
                            break;
                        }
                    case "3":
                        {
                            Console.Write("Product's Cag_id :");
                            int id = int.Parse(Console.ReadLine());
                            var result = proService.GetByCagID(id);
                            display.Display_pro(result, cagService);
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

                            var list = proService.GetByDate_Added(firstDate, lastDate);
                            display.Display_pro(list, cagService);
                            break;
                        }
                    case "5":
                        {
                            Console.Write("Product's name :");
                            string name = Console.ReadLine();
                            var result = proService.GetByName(name);
                            display.Display_pro(result, cagService);
                            break;
                        }
                    case "6":
                        {
                            Console.Write("Price 1 :");
                            decimal price1 = decimal.Parse(Console.ReadLine());
                            Console.Write("Price 2 :");
                            decimal price2 = decimal.Parse(Console.ReadLine());
                            var result = proService.GetByPrice(price1, price2);
                            display.Display_pro(result, cagService);
                            break;
                        }
                    case "7":
                        {
                            Console.Write("Description :");
                            string description = Console.ReadLine();
                            var result = proService.GetBy_Description(description);
                            display.Display_pro(result, cagService);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Error!!");
                            Console.WriteLine("|--------------------------------------------------------------------------------------------------------------------|");
                            break;
                        }
                }
            } while (chon != "0");
        }
}
}