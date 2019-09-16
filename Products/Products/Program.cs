using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    class Program
    {
        static void Main(string[] args)
        {

            var product = new Product("Nintendo Switch", 299.99m);
            // product.Name = "Nintendo Switch";
            // product.Price = 299.99m;
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
            Console.ReadLine();
        }
    }
}
