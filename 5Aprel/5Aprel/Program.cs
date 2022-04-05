using System;
using ClassLibrary;
namespace _5Aprel
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int productLimit = Convert.ToInt32(Console.ReadLine());*/
            
            Store newProduct = new Store();
            Notebook newNotebook = new Notebook();
            /*Console.WriteLine("Write notelimit:");
            newProduct.NotebookLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write phonelimit:");
            newProduct.PhoneLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("write name:");
            newNotebook.Name = Console.ReadLine();
            Console.WriteLine("write no");
            newNotebook.No = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("write price");
            newNotebook.Price = Convert.ToDouble(Console.ReadLine());
            
            foreach (var item in newProduct.AddProduct(newNotebook))
            {
                Console.WriteLine(item.Name);
            }*/
            /*newProduct.NotebookLimit = 1;
            newProduct.PhoneLimit = 1;*/
            for (int i = 0; i < 3; i++)
            {
                newProduct.Products = new Product[]
                {
                    new  Product
                    {

                         Name = Console.ReadLine(),
                         Price = Convert.ToDouble(Console.ReadLine()),
                         No = Convert.ToInt32(Console.ReadLine()),
                         
                    },


                };
                newProduct.AddProduct(newProduct.Products[i]);
            }
            
            
            
            foreach (var item in newProduct.Products)
            {
                Console.WriteLine(item.Name);
            }
            
            
                

            






        }
    }
}
