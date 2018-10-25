using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Nine
{
    public class WeirdCalculator
    {
        private readonly Node _tree;
        public WeirdCalculator()
        {
            _tree = new Node();

            _tree.ChildNodes = new List<Node>
            {
                new Node
                {
                    ChildNodes = new List<Node>(),
                    Leaves = new List<Leaf> {
                        CreateUser(), CreateUser(), CreateUser(), CreateMachine()
                    }
                },
                new Node
                {
                    ChildNodes = new List<Node>(),
                    Leaves = new List<Leaf> {
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

        private int CalculateSumOfNameLengthsForLeaves(List<Leaf> leaves)
        {
            int sum = 0;
            foreach (Leaf l in leaves)
            {
                if (l is User)
                {
                    sum += (l as User).Name.Length;
                }
                else if (l is Machine)
                {
                    sum += (l as Machine).Name.Length;
                }
            }
            return sum;
        }

        private int CalculateSumOfNameLengthsForNodes(List<Node> childNodes)
        {
            int sum = 0;
            foreach (Node n in childNodes)
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

        private int CalculateSumOfNumericValuesForLeaves(List<Leaf> leaves)
        {
            int sum = 0;
            foreach (Leaf l in leaves)
            {
                if (l is User)
                {
                    sum += (l as User).Age;
                }
                else if (l is Machine)
                {
                    sum += (l as Machine).IP.Split('.').Select(s => Int32.Parse(s)).Sum();
                }
            }
            return sum;
        }

        private int CalculateSumOfNumericValuesForNodes(List<Node> childNodes)
        {
            int sum = 0;
            foreach (Node n in childNodes)
            {
                sum += CalculateSumOfNumericValuesForNodes(n.ChildNodes);
                sum += CalculateSumOfNumericValuesForLeaves(n.Leaves);
            }
            return sum;
        }

        private Leaf CreateUser() => new User { Age = 12, Name = "toto" };

        private Leaf CreateMachine() => new Machine { IP = "127.0.0.1", Name = "Home" };
    }
}
