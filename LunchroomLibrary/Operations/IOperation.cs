using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchroomLibrary.Operations
{
    interface IOperation
    {
        string Name { get; set; }
        double Lasting { get; set; }
        double Price { get; set; }
        int Number { get; set; }
        DateTime StartOperation { get; set; }
    }
}
