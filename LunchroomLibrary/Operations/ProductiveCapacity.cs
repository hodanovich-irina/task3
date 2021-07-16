using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchroomLibrary.Operations
{
    /// <summary>
    /// Class for productive capacity
    /// </summary>
    /// <typeparam name="T">type element</typeparam>
    public class ProductiveCapacity<T>
    {
        /// <summary>
        /// Empty constructor
        /// </summary>
        public ProductiveCapacity() { }

        /// <summary>
        /// Constructor with params
        /// </summary>
        /// <param name="maxNumber">Max number of operation</param>
        public ProductiveCapacity(int maxNumber)
        {
            MaxNumber = maxNumber;
        }

        /// <summary>
        /// Max number of operation
        /// </summary>
        public int MaxNumber { get; set; }

        /// <summary>
        /// Override method ToString()
        /// </summary>
        /// <returns>string</returns>
        public override string ToString() 
        {
            return MaxNumber.ToString();
        }

        /// <summary>
        /// Method overriding Equals()
        /// </summary>
        /// <param name="obj">Object</param>
        /// <returns>True or false</returns>
        public override bool Equals(object obj)
        {
            return obj is ProductiveCapacity<T> capacity &&
                   MaxNumber == capacity.MaxNumber;
        }

        /// <summary>
        /// Method overriding GetHashCode()
        /// </summary>
        /// <returns>Hash-code</returns>
        public override int GetHashCode()
        {
            return 187193536 + MaxNumber.GetHashCode();
        }
    }
}
