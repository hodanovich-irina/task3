using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchroomLibrary.LunchroomMenu
{
    /// <summary>
    /// Class for drink
    /// </summary>
    public class Drink
    {
        /// <summary>
        /// Empty constructor
        /// </summary>
        public Drink() { }

        /// <summary>
        /// Constructor with params
        /// </summary>
        /// <param name="name">Name of drink</param>
        /// <param name="price">Price of drin</param>
        public Drink(string name, double price)
        {
            Name = name;
            Price = price;
        }

        /// <summary>
        /// Name of drink
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Price of drink
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Method overriding Equals()
        /// </summary>
        /// <param name="obj">Object</param>
        /// <returns>True or false</returns>
        public override bool Equals(object obj)
        {
            return obj is Drink drink &&
                   Name == drink.Name &&
                   Price == drink.Price;
        }

        /// <summary>
        /// Method overriding GetHashCode()
        /// </summary>
        /// <returns>Hash-code</returns>
        public override int GetHashCode()
        {
            int hashCode = -44027456;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + Price.GetHashCode();
            return hashCode;
        }

        /// <summary>
        /// Override method ToString()
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return Name;
        }
    }
}
