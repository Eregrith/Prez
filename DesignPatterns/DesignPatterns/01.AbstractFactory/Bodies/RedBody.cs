namespace DesignPatterns.AbstractFactory
{
    internal class RedBody : Body
    {
        public string What { get; }

        public RedBody(string what)
        {
            What = what;
        }
    }
}