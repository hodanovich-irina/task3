using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchroomLibrary.Operations
{
    public class Operation : ProductiveCapacity<Operation>, IOperation
    {
        public Operation(string name, double lasting, double price, int number) : base(number)
        {
            Name = name;
            Lasting = lasting;
            Price = price;
        }

        public string Name { get; set; }
        public double Lasting { get; set; }
        public double Price { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Operation operation &&
                   base.Equals(obj) &&
                   Number == operation.Number &&
                   Name == operation.Name &&
                   Lasting == operation.Lasting &&
                   Price == operation.Price;
        }

        public override int GetHashCode()
        {
            int hashCode = -1057568171;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + Number.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + Lasting.GetHashCode();
            hashCode = hashCode * -1521134295 + Price.GetHashCode();
            return hashCode;
        }
    }
}