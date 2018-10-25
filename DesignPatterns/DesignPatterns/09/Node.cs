using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Nine
{
    public class Node
    {
        public List<Node> ChildNodes { get; set; }
        public List<Leaf> Leaves { get; set; }
    }
}
