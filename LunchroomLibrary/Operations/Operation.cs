using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchroomLibrary.Operations
{
    public class Operation : ProductiveCapacity<Operation>, IOperation
    {
        public Operation() { }
        public Operation(string name, double lasting, double price, DateTime startOperation,int number, int maxNumber) : base(maxNumber)
        {
            Name = name;
            Lasting = lasting;
            Price = price;
            StartOperation = startOperation;
            Number = number;

        }

        public string Name { get; set; }
        public double Lasting { get; set; }
        public double Price { get; set; }
        public DateTime StartOperation { get; set; }
        public int Number { get; set; }

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
    }
}