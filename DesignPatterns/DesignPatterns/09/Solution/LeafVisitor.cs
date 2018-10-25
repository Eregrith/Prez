namespace DesignPatterns.Visitor.Solution
{
    public abstract class LeafVisitor
    {
        public abstract int Visit(User user);
        public abstract int Visit(Machine machine);
    }
}