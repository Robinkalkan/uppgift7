using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace uppgift7 { }
public class Rektangel : Geometri
{
    public double Length { get; set; }
    public double Width { get; set; }

    public Rektangel(double length, double width)
    {
        Length = length;
        Width = width;
    }

    public override double Area()
    {
        return Length * Width;
    }
}

