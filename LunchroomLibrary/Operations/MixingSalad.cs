using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchroomLibrary.Operations
{
    /// <summary>
    /// Сlass added to developed and tested code
    /// </summary>
    public class MixingSalad : Operation
    {
        /// <summary>
        /// Empty constructor
        /// </summary>
        public MixingSalad()
        {
        }

        /// <summary>
        /// Constructor with params
        /// </summary>
        /// <param name="name">Name of operation</param>
        /// <param name="lasting">Lasting of operation</param>
        /// <param name="price">Price of operation</param>
        /// <param name="startOperation">Start time of operation</param>
        /// <param name="number">Number of operation</param>
        /// <param name="maxNumber">Max number of operation</param>
        public MixingSalad(string name, double lasting, double price, DateTime startOperation, int number, int maxNumber) : base(name, lasting, price, startOperation, number, maxNumber)
        {
        }

        /// <summary>
        /// Method overriding Equals()
        /// </summary>
        /// <param name="obj">Object</param>
        /// <returns>True or false</returns>
        public override bool Equals(object obj)
        {
            return obj is MixingSalad salad &&
                   base.Equals(obj) &&
                   MaxNumber == salad.MaxNumber &&
                   Name == salad.Name &&
                   Lasting == salad.Lasting &&
                   Price == salad.Price &&
                   StartOperation == salad.StartOperation &&
                   Number == salad.Number;
        }

        /// <summary>
        /// Method overriding GetHashCode()
        /// </summary>
        /// <returns>Hash-code</returns>
        public override int GetHashCode()
        {
            int hashCode = -1079755483;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + MaxNumber.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + Lasting.GetHashCode();
            hashCode = hashCode * -1521134295 + Price.GetHashCode();
            hashCode = hashCode * -1521134295 + StartOperation.GetHashCode();
            hashCode = hashCode * -1521134295 + Number.GetHashCode();
            return hashCode;
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
