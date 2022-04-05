using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Store
    {
        
        private Product[] _products = new Product[0];
        public Product[] Products
        {
            get { return this._products; }
            set { this._products = value; }

        }
        public int NotebookLimit { get; set; }
        public int PhoneLimit { get; set; }

        public Product[] AddProduct(Product product) 
        {
            
            
            
                for (int Note = 0; Note <= NotebookLimit; Note++)
                {
                    if (Note is Notebook)
                    {

                        Array.Resize(ref _products, _products.Length + 1);
                        _products[_products.Length - 1] = product;
                        

                    }
                }
                for (int Ph = 0; Ph <= PhoneLimit; Ph++)
                {
                    if (Ph is Phone)
                    {
                        Array.Resize(ref _products, _products.Length + 1);
                        _products[_products.Length - 1] = product;
                        

                    }
                }return _products;
                
          
            
        }
        public void FindNo (int PrNo) 
        {


            for (int i = 0; i <_products.Length; i++)
            {
                if (_products[i].No == PrNo)
                {
                    Console.WriteLine($"Product name-{_products[i].Name} product no-{_products[i].No}");
                }
            }
            
        }
        public double CalcNoteBookAvg() 
        {
            int count = 0;
            double sum = 0;
            foreach (var note in _products)
            {
                if (note is Notebook)
                {
                    count++;
                    sum += note.Price;

                }
            }return sum / count;

        }
        public double CalcPhoneAvg()
        {
            int count = 0;
            double sum = 0;
            foreach (var phone in _products)
            {
                if (phone is Phone)
                {
                    count++;
                    sum += phone.Price;

                }
            }
            return sum / count;

        }




    }
}
