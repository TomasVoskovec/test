using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Field
    {
        public int X { get; set; }
        public int Y { get; set; }

        //0 = empty, 1 = boat, 2 = scope, 3 = miss, 4 = shot
        public int Type { get; set; }
    }
}