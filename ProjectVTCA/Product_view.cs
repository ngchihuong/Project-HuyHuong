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
    public class Product_view
    {
        public void Pro_view(ProductService proService , CategoryService cagService)
        {
            string chon;
            
            Menu menu = new Menu();
            Display display = new Display();
            do
            {
                menu.Menu_Pro();
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
                            Products products = new Products();
                            //Console.Write("Product'S ID: ");
                            //products.Pro_ID = int.Parse(Console.ReadLine());
                            Console.Write("Product's name: ");
                            products.Pro_Name = Console.ReadLine();
                                bool cag_valid = false;
                            display.Display_cag(cagService.GetAll());
                            do
                            {
                            Console.Write("Cag_ID: ");
                            int cag_id = int.Parse(Console.ReadLine());
                                if (cagService.GetByID(cag_id) != null)
                                {
                                    cag_valid = true;
                                    products.Cag_ID = cag_id;
                                }
                                else
                                {
                                    Console.WriteLine("Customer not exist!");
                                }
                            } while (!cag_valid);
                            products.Date_Added = DateTime.Now;
                            Console.Write("Description: ");
                            products.Description = Console.ReadLine();

                            /*decimal price;
                            bool isValid = false;
                            do
                            {
                                Console.Write("Price: ");
                                string input = Console.ReadLine();

                                if (!isValid)
                                {
                                    Console.WriteLine("Invalid input! Please enter a valid decimal greater than 0.");
                                }
                                isValid = decimal.TryParse(input, out price) && price > 0;
                                products.Price = decimal.Parse(input);
                            } while (!isValid);*/

                            bool quantity_valid = false;
                            string quantity;
                            do
                            {
                                Console.Write("Quantity : ");
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
                                        products.Quantity = int.Parse(quantity);
                                        quantity_valid = true;
                                    }
                                }
                            } while (quantity_valid == false);

                            bool quantity_valid = false;
                            string quantity;
                            do
                            {
                                Console.Write("Quantity : ");
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
                                        products.Quantity = int.Parse(quantity);
                                            quantity_valid = true;
                                    }
                                }
                            } while (quantity_valid == false);

                            Console.Write("Pro_Brand: ");
                            products.Pro_Brand = Console.ReadLine();
                            products.status = 1;
                            var result = proService.Insert(products);
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
                            Products products = new Products();
                            Console.WriteLine("Enter product's information need to be updated!");
                            Console.Write("Enter ID: ");
                            int id = int.Parse(Console.ReadLine());
                            var result = proService.GetByID(id);
                            if (result == null)
                            {
                                Console.WriteLine("Product not found!");
                            }
                            else
                            {
                                //Console.Write("Product'S ID: ");
                                //products.Pro_ID = int.Parse(Console.ReadLine());
                                Console.Write("Product's name: ");
                                products.Pro_Name = Console.ReadLine();

                                bool cag_valid = false;
                                display.Display_cag(cagService.GetAll());
                                do
                                {
                                    Console.Write("Cag_ID: ");
                                    int cag_id = int.Parse(Console.ReadLine());
                                    if (cagService.GetByID(cag_id) != null)
                                    {
                                        cag_valid = true;
                                        products.Cag_ID = cag_id;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Category ID not exist!");
                                    }
                                } while (!cag_valid);

                                products.Date_Added = DateTime.Now;
                                Console.Write("Description: ");
                                products.Description = Console.ReadLine();

                                decimal price;
                                bool isValid = false;
                                do
                                {
                                    Console.Write("Price: ");
                                    string input = Console.ReadLine();

                                    isValid = decimal.TryParse(input, out price) && price > 0;
                                    products.Price = decimal.Parse(input);
                                    if (!isValid)
                                    {
                                        Console.WriteLine("Invalid input! Please enter a valid decimal greater than 0.");
                                    }
                                } while (!isValid);

                                bool quantity_valid = false;
                                string quantity;
                                do
                                {
                                    Console.Write("Quantity : ");
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
                                            products.Quantity = int.Parse(quantity);
                                            quantity_valid = true;
                                        }
                                    }
                                } while (quantity_valid == false);

                                Console.Write("Pro_Brand: ");
                                products.Pro_Brand = Console.ReadLine();
                                products.status = 1;
                                var result1 = proService.Update(products, id);
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
                            Console.WriteLine("Product's ID: ");
                            int id = int.Parse(Console.ReadLine());
                            var result = proService.GetByID(id);
                            if (result == null)
                            {
                                Console.WriteLine("Product not found!");
                            }
                            else
                            {
                                var result1 = proService.Delete(id);
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
                            var list = proService.GetAll();
                            display.Display_pro(list , cagService);
                            break;
                        }
                    case "5":
                        {
                            Console.Write("Product's ID :");
                            int id = int.Parse(Console.ReadLine());
                            var result = proService.GetByID(id);
                            display.Display_pro1(result , cagService);
                            break;
                        }
                    case "6":
                        {
                            Console.Write("Product's Cag_id :");
                            int id = int.Parse(Console.ReadLine());
                            var result = proService.GetByCagID(id);
                            display.Display_pro(result , cagService);
                            break;

                        }
                    case "7":
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
                            display.Display_pro(list , cagService);
                            break;
                        }
                    case "8":
                        {
                            Console.Write("Product's name :");
                            string name = Console.ReadLine();
                            var result = proService.GetByName(name);
                            display.Display_pro(result , cagService);
                            break;
                        }
                    case "9":
                        {
                            Console.Write("Price 1 :");
                            decimal price1 = decimal.Parse(Console.ReadLine());
                            Console.Write("Price 2 :");
                            decimal price2 = decimal.Parse(Console.ReadLine());
                            var result = proService.GetByPrice(price1, price2);
                            display.Display_pro(result , cagService);
                            break;
                        }
                    case "10":
                        {
                            Console.Write("Description :");
                            string description = Console.ReadLine();
                            var result = proService.GetBy_Description(description);
                            display.Display_pro(result , cagService);
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
