using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystemPro
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            bool exit = true;
            while (exit)
            {

                Console.WriteLine("1. purchase products for shop from Main Store");
                Console.WriteLine("2. show all products of shop");
                Console.WriteLine("3. show all products of Main Store");
                Console.WriteLine("4. purchase products from shop");
                Console.WriteLine("5. exit");

                Console.WriteLine("enter a number");

                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        exit=false;
                        break;

                }
            }
        }
    }
}
