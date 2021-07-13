using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchroomLibrary.Operations
{
    public class Cutting : ProductiveCapacity<Cutting>, IOperation
    {
        public Cutting(string name, DateTime lasting, double price, int number) : base(number)
        {
            Name = name;
            Lasting = lasting;
            Price = price;
        }

        public string Name { get; set; }
        public DateTime Lasting { get; set; }
        public double Price { get; set; }

        /// <summary>
        /// Method overriding Equals()
        /// </summary>
        /// <param name="obj">Object</param>
        /// <returns>True or false</returns>
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        /// <summary>
        /// Method overriding GetHashCode()
        /// </summary>
        /// <returns>Hash-code</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// Override method ToString()
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
