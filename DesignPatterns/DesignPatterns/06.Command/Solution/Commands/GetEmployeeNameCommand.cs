using System;

namespace DesignPatterns.Command.Solution
{
    public class GetEmployeeNameCommand : AbstractCommand
    {
        private readonly IService _service;
        public Guid Id { get; set; }

        public GetEmployeeNameCommand(IService service)
        {
            _service = service;
        }

        public override Result Execute()
        {
            return new StringResult(_service.GetEmployeeName(Id));
        }
    }
}