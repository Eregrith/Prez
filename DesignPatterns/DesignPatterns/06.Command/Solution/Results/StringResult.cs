namespace DesignPatterns.Command.Solution
{
    internal class StringResult : Result
    {
        private string v;

        public StringResult(string v)
        {
            this.v = v;
        }
    }
}