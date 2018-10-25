using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor.Solution
{
    public abstract class VisitableLeaf
    {
        public abstract int Accept(LeafVisitor visitor);
    }
}
