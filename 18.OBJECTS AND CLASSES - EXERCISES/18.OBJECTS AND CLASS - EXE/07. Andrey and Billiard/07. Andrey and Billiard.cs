using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Andrey_and_Billiard
{
    class Program
    {
        static void Main(string[] args)
        {
            var countPrices = int.Parse(Console.ReadLine());
            var menu = new Dictionary<string, decimal>();
            for (int i = 0; i < countPrices; i++)
            {
                var separatedPrices = Console.ReadLine().Split('-').ToList();
                if (menu.ContainsKey(separatedPrices[0]) == false)
                {
                    menu.Add(separatedPrices[0], 0.0m);
                }

                menu[separatedPrices[0]] = decimal.Parse(separatedPrices[1]);
            }

            var customers = new List<Customer>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end of clients")
                {
                    break;
                }

                var customerCurrent = new Customer();
                var separatedName = input.Split('-').ToList();
                customerCurrent.Name = separatedName[0];
                var prodoctCurrent = new Dictionary<string, decimal>();
                customerCurrent.Products = prodoctCurrent;
                var separatedProduct = separatedName[1].Split(',').ToList();
                if (menu.ContainsKey(separatedProduct[0]) == true)
                {
                    if (customerCurrent.Products.ContainsKey(separatedProduct[0]) == false)
                    {
                        customerCurrent.Products.Add(separatedProduct[0], 0.0m);
                    }

                    customerCurrent.Products[separatedProduct[0]] += decimal.Parse(separatedProduct[1]);
                    //var names = customers.Select(x => x.Name).ToList();
                    //var isContains = false;
                    //foreach (var name in names)
                    //{
                    //    if (name == customerCurrent.Name)
                    //    {
                    //        isContains = true;
                    //        break;
                    //    }
                    //}
                    //
                    //if (isContains)
                    //{
                    //    customers.GroupBy(x => )
                    //}
                    var product = separatedProduct[0];
                    var quantity = decimal.Parse(separatedProduct[1]);


                    if (customers.Any(x => x.Name == customerCurrent.Name))
                    {
                        var currentCustomer = customers.First(x => x.Name == customerCurrent.Name);

                        if (currentCustomer.Products.ContainsKey(product))
                        {
                            currentCustomer.Products[product] += quantity;
                            //currentCustomer.Bill += shop[product] * customerQuantity;
                        }
                        else
                        {
                            currentCustomer.Products[product] = quantity;
                            //currentCustomer.Bill += shop[product] * customerQuantity;
                        }
                    }
                    else
                    {
                        customers.Add(customerCurrent);
                    }
                }
            }

            foreach (var customer in customers)
            {
                customer.Menu = menu;
            }

            foreach (var customer in customers.OrderBy(c => c.Name))
            {
                Console.WriteLine(customer.Name);
                foreach (var item in customer.Products)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value:F0}");
                }

                Console.WriteLine($"Bill: {customer.Bill:F2}");
            }

            Console.WriteLine($"Total bill: {customers.Sum(c => c.Bill):F2}");
        }
    }
}
