using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor.Solution
{
    public class WeirdCalculator
    {
        private readonly VisitableNode _tree;
        public WeirdCalculator()
        {
            _tree = new VisitableNode();

            _tree.ChildNodes = new List<VisitableNode>
            {
                new VisitableNode
                {
                    ChildNodes = new List<VisitableNode>(),
                    Leaves = new List<VisitableLeaf> {
                        CreateUser(), CreateUser(), CreateUser(), CreateMachine()
                    }
                },
                new VisitableNode
                {
                    ChildNodes = new List<VisitableNode>(),
                    Leaves = new List<VisitableLeaf> {
                        CreateUser(), CreateMachine(), CreateMachine(), CreateUser(), CreateMachine()
                    }
                },
            };
        }

        public int CalculateSumOfNameLengths()
        {
            int sum = 0;
            sum += CalculateSumOfNameLengthsForNodes(_tree.ChildNodes);
            sum += CalculateSumOfNameLengthsForLeaves(_tree.Leaves);
            return sum;
        }

        private int CalculateSumOfNameLengthsForLeaves(List<VisitableLeaf> leaves)
        {
            LengthOfNamevisitor visitor = new LengthOfNamevisitor();
            int sum = 0;
            foreach (VisitableLeaf l in leaves)
            {
                sum += l.Accept(visitor);
            }
            return sum;
        }

        private int CalculateSumOfNameLengthsForNodes(List<VisitableNode> childNodes)
        {
            int sum = 0;
            foreach (VisitableNode n in childNodes)
            {
                sum += CalculateSumOfNameLengthsForNodes(n.ChildNodes);
                sum += CalculateSumOfNameLengthsForLeaves(n.Leaves);
            }
            return sum;
        }

        public int CalculateSumOfNumericValues()
        {
            int sum = 0;
            sum += CalculateSumOfNumericValuesForNodes(_tree.ChildNodes);
            sum += CalculateSumOfNumericValuesForLeaves(_tree.Leaves);
            return sum;
        }

        private int CalculateSumOfNumericValuesForLeaves(List<VisitableLeaf> leaves)
        {
            SumOfNumericPropertiesVisitor visitor = new SumOfNumericPropertiesVisitor();
            int sum = 0;
            foreach (VisitableLeaf l in leaves)
            {
                l.Accept(visitor);
            }
            return sum;
        }

        private int CalculateSumOfNumericValuesForNodes(List<VisitableNode> childNodes)
        {
            int sum = 0;
            foreach (VisitableNode n in childNodes)
            {
                sum += CalculateSumOfNumericValuesForNodes(n.ChildNodes);
                sum += CalculateSumOfNumericValuesForLeaves(n.Leaves);
            }
            return sum;
        }

        private VisitableLeaf CreateUser() => new User { Age = 12, Name = "toto" };

        private VisitableLeaf CreateMachine() => new Machine { IP = "127.0.0.1", Name = "Home" };
    }
}
