using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    internal class Parallelepiped:Body
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Parallelepiped(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public override double Area()
        {
            return 2 * (A * B + B * C + A * C);
        }
        public override double Volume()
        {
            return (A * B * C);
        }
        public override string Print()
        {
            return ($"S = {Area():F2}, V = {Volume():F2}");
        }
    }
}
