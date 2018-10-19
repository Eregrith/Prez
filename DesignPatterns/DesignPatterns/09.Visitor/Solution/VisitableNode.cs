using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor.Solution
{
    public class VisitableNode
    {
        public List<VisitableNode> ChildNodes { get; set; }
        public List<VisitableLeaf> Leaves { get; set; }
    }
}
