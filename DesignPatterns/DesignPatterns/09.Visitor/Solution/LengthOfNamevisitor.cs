using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor.Solution
{
    public class LengthOfNamevisitor : LeafVisitor
    {
        public override int Visit(User user)
        {
            return user.Name.Length;
        }

        public override int Visit(Machine machine)
        {
            return machine.Name.Length;
        }
    }
}
