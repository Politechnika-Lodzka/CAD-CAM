using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model3.Interfaces
{
    interface IPoint3: IPoint
    {
        double Z { get; set; }
    }
}
