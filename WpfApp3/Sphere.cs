using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    internal class Sphere:Body
    {
        public double R { get; set; }
        public Sphere(double r)
        {
            R = r;
        }
        public override double Area()
        {
            return (4 * Math.PI * R * R);
        }
        public override double Volume()
        {
            return ((4 / 3) * Math.PI * Math.Pow(R, 3));
        }
        public override string Print()
        {
            return ($"S = {Area():F2}, V = {Volume():F2}");
        }
    }
}
