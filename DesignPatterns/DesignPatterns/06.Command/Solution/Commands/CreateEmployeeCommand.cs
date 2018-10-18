namespace DesignPatterns.Command.Solution
{
    public class CreateEmployeeCommand : AbstractCommand
    {
        private readonly IService _service;
        public string Name { get; set; }
        public int Age { get; set; }

        public CreateEmployeeCommand(IService service)
        {
            _service = service;
        }

        public override Result Execute()
        {
            _service.CreateEmployee(Name, Age);
            return new SuccessResult();
        }
    }
}