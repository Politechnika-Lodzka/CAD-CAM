﻿using Model3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model3.Models
{
    class Point3 : IPoint3
    {
        public double Z { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public int Id { get; set; }
    }
}