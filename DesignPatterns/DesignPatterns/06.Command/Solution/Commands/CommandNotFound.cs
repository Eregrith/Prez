namespace DesignPatterns.Command.Solution
{
    public class CommandNotFound : AbstractCommand
    {
        public override Result Execute()
        {
            return new Error404Result();
        }
    }
}