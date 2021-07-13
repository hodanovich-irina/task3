using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchroomLibrary.LunchroomMenu
{
    public class Drink
    {
        public Drink() { }
        public Drink(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public double Price { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Drink drink &&
                   Name == drink.Name &&
                   Price == drink.Price;
        }

        public override int GetHashCode()
        {
            int hashCode = -44027456;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + Price.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
