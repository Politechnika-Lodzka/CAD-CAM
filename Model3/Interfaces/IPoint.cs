﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model3.Interfaces
{
    interface IPoint
    {
        int Id { get; set; }
        double X { get; set; }
        double Y { get; set; }
    }
}
