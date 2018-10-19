using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    public class Machine : Leaf
    {
        public string IP { get; set; }
        public string Name { get; set; }
    }
}
