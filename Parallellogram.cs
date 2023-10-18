using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift7 { }

public class Parallellogram : Geometri
{
    public double Base { get; set; }
    public double Height { get; set; }

    public Parallellogram(double @base, double height)
    {
        Base = @base;
        Height = height;
    }

    public override double Area()
    {
        return Base * Height;
    }
}
