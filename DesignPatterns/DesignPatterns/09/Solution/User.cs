using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor.Solution
{
    public class User : VisitableLeaf
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override int Accept(LeafVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
