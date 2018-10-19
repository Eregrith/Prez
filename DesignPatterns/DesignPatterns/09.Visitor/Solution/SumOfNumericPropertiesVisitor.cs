using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor.Solution
{
    public class SumOfNumericPropertiesVisitor : LeafVisitor
    {
        public override int Visit(User user)
        {
            return user.Age;
        }

        public override int Visit(Machine machine)
        {
            return machine.IP.Split('.').Select(s => Int32.Parse(s)).Sum();
        }
    }
}
