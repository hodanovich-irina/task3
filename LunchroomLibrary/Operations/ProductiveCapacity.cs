using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchroomLibrary.Operations
{
    public class ProductiveCapacity<T>
    {
        public ProductiveCapacity() { }
        public ProductiveCapacity(int maxNumber)
        {
            MaxNumber = maxNumber;
        }

        public int MaxNumber { get; set; }

        public override string ToString() 
        {
            return MaxNumber.ToString();
        }
        public override bool Equals(object obj)
        {
            return obj is ProductiveCapacity<T> capacity &&
                   MaxNumber == capacity.MaxNumber;
        }

        public override int GetHashCode()
        {
            return 187193536 + MaxNumber.GetHashCode();
        }
    }
}
