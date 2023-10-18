using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift7 { }
public class Ellipse : Geometri
{
    public double MajorAxis { get; set; }
    public double MinorAxis { get; set; }

    public Ellipse(double majorAxis, double minorAxis)
    {
        MajorAxis = majorAxis;
        MinorAxis = minorAxis;
    }

    public override double Area()
    {
        return Math.PI * MajorAxis * MinorAxis;
    }
}