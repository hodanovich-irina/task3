using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchroomLibrary.Operations
{
    public class ProductiveCapacity<T>
    {
        public ProductiveCapacity(int number)
        {
            Number = number;
        }

        public int Number { get; set; }

        public override bool Equals(object obj)
        {
            return obj is ProductiveCapacity<T> capacity &&
                   Number == capacity.Number;
        }

        public override int GetHashCode()
        {
            return 187193536 + Number.GetHashCode();
        }
    }
}
