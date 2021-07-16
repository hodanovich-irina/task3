using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchroomLibrary.Operations
{
    /// <summary>
    /// Class for baking operation
    /// </summary>
    public class Baking : Operation
    {
        /// <summary>
        /// Empty constructor
        /// </summary>
        public Baking() { }

        /// <summary>
        /// Constructor with params
        /// </summary>
        /// <param name="name">Name of operation</param>
        /// <param name="lasting">Lasting of operation</param>
        /// <param name="price">Price of operation</param>
        /// <param name="startOperation">Start time of operation</param>
        /// <param name="number">Number of operation</param>
        /// <param name="maxNumber">Max number of operation</param>
        public Baking(string name, double lasting, double price, DateTime startOperation, int number, int maxNumber) : base(name, lasting, price, startOperation, number, maxNumber)
        {
        }

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
