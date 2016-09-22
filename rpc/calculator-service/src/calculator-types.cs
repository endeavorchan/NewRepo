using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Calculator
{
    public partial class BinaryOpArgs
    {
        public double left { get; set; }
        public double right { get; set; }
        public BinaryOpArgs()
            : this("Example.Calculator.BinaryOpArgs", "BinaryOpArgs")
        { }

        protected BinaryOpArgs(string fullName, string name)
        {

        }
    }
}
