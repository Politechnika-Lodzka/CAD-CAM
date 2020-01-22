using Model3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model3.Models
{
    class Line : ILine
    {
        public Point Point1 { get; set; }
        public Point Point2 { get; set; }
    }
}
