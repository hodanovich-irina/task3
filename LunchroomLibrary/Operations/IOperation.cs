using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchroomLibrary.Operations
{
    /// <summary>
    /// Interface for operation
    /// </summary>
    interface IOperation
    {
        /// <summary>
        /// Namr of operation
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Lasting of operation
        /// </summary>
        double Lasting { get; set; }

        /// <summary>
        /// Price of operation
        /// </summary>
        double Price { get; set; }

        /// <summary>
        /// Number of operation
        /// </summary>
        int Number { get; set; }

        /// <summary>
        /// Start time of operation
        /// </summary>
        DateTime StartOperation { get; set; }
    }
}
