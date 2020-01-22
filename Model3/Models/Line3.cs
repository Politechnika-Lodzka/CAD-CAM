using Model3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model3.Models
{
    class Line3 : ILine3
    {
        public Point3 Point1 { get; set; }
        public Point3 Point2 { get; set; }
    }
}
