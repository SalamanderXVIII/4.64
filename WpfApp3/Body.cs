using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    internal abstract class Body
    {
        public abstract double Area();
        public abstract double Volume();
        public abstract string Print();
    }
}
