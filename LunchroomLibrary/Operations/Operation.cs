using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchroomLibrary.Operations
{
    /// <summary>
    /// Class for operation
    /// </summary>
    public class Operation : ProductiveCapacity<Operation>, IOperation
    {
        /// <summary>
        /// Empty constructor
        /// </summary>
        public Operation() { }

        /// <summary>
        /// Constructor with params
        /// </summary>
        /// <param name="name">Name of operation</param>
        /// <param name="lasting">Lasting of operation</param>
        /// <param name="price">Price of operation</param>
        /// <param name="startOperation">Start time of operation</param>
        /// <param name="number">Number of operation</param>
        /// <param name="maxNumber">Max number of operation</param>
        public Operation(string name, double lasting, double price, DateTime startOperation,int number, int maxNumber) : base(maxNumber)
        {
            Name = name;
            Lasting = lasting;
            Price = price;
            StartOperation = startOperation;
            Number = number;

        }

        /// <summary>
        /// Name of operation
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Lasting of operation
        /// </summary>
        public double Lasting { get; set; }

        /// <summary>
        /// Price of operation
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Start time of operation
        /// </summary>
        public DateTime StartOperation { get; set; }

        /// <summary>
        /// Number of operation
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Method overriding Equals()
        /// </summary>
        /// <param name="obj">Object</param>
        /// <returns>True or false</returns>
        public override bool Equals(object obj)
        {
            return obj is Operation operation &&
                   base.Equals(obj) &&
                   MaxNumber == operation.MaxNumber &&
                   Name == operation.Name &&
                   Lasting == operation.Lasting &&
                   Price == operation.Price &&
                   StartOperation == operation.StartOperation;
        }

        /// <summary>
        /// Method overriding GetHashCode()
        /// </summary>
        /// <returns>Hash-code</returns>
        public override int GetHashCode()
        {
            int hashCode = -1587887911;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + MaxNumber.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + Lasting.GetHashCode();
            hashCode = hashCode * -1521134295 + Price.GetHashCode();
            hashCode = hashCode * -1521134295 + StartOperation.GetHashCode();
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