using Model3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model3.Interfaces
{
    interface ILine
    {
        Point Point1 { get; set; }
        Point Point2 { get; set; }
    }
}
