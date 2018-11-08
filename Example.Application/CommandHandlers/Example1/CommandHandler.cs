using ExampleDomain.Commands.Example1;
using System;

namespace Example.Application.CommandHandlers.Example1
{
    public class CommandHandler : ICommandHandler<ExampleCommand>
    {


        public void Handle(ExampleCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
