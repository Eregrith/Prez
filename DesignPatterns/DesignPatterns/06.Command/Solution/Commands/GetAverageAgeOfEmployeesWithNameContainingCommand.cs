namespace DesignPatterns.Command.Solution
{
    public class GetAverageAgeOfEmployeesWithNameContainingCommand : AbstractCommand
    {
        private readonly IService _service;
        public string PartOfName { get; set; }

        public GetAverageAgeOfEmployeesWithNameContainingCommand(IService service)
        {
            _service = service;
        }

        public override Result Execute()
        {
            return new IntegerResult(_service.GetAverageAgeOfEmployeesWithNameContaining(PartOfName));
        }
    }
}