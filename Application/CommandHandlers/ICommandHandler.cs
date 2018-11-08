using ExampleDomain.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Application.CommandHandlers
{
    public interface ICommandHandler<TCommand> where TCommand : ICommand
    {
        void Handle(TCommand command);
    }
}
