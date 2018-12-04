using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseNine
{
    public class Product
    {
        public string Name;
        public string Description;
        public double Price;
        public int Items;
        public double Rate;

        public Product(string name, double price, int items, double rate)
        {
            Name = name;
            Price = price;
            Items = items;
            Rate = rate;
        }
        public string GetDescription()
        {
            return Description;
        }

        public void DeductItems(int items)
        {
            Items = Items - items;
        }
        public ObservableCollection<double> listofgrade = new ObservableCollection<double>();
        
    }
}
