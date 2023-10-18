using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift7 { }
public class Fyrkant : Geometri
{
    public double Side { get; set; }

    public Fyrkant(double side)
    {
        Side = side;
    }

    public override double Area()
    {
        return Side * Side;
    }
}