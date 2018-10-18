using Nancy;
using Nancy.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command.Solution
{
    public class NancyApi : NancyModule
    {
        public NancyApi()
        {
            Get["/Execute/{type}"] = parameters =>
            {
                AbstractCommand command;

                command = GetConcreteCommand(parameters.type);

                return command.Execute();
            };
        }

        private AbstractCommand GetConcreteCommand(string type)
        {
            AbstractCommand command;
            switch (type)
            {
                case "GetEmployeeName":
                    command = this.Bind<GetEmployeeNameCommand>();
                    break;
                case "GetAverageAgeOfEmployeesWithNameContaining":
                    command = this.Bind<GetAverageAgeOfEmployeesWithNameContainingCommand>();
                    break;
                case "CreateEmployee":
                    command = this.Bind<CreateEmployeeCommand>();
                    break;
                default:
                    command = this.Bind<CommandNotFound>();
                    break;
            }

            return command;
        }
    }
}
