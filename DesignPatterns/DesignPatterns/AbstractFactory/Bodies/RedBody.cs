namespace DesignPatterns.AbstractFactory
{
    internal class RedBody : Body
    {
        public readonly string What { get; set; }

        public RedBody(string what)
        {
            What = what;
        }
    }
}