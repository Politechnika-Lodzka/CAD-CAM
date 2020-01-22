using Model3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model3.Models
{
    class Point : IPoint
    {
        public double X { get; set; }
        public double Y { get; set; }
        public int Id { get; set; }
    }
}
