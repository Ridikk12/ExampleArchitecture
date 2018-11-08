using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Example.Application.CommandHandlers;
using ExampleDomain.Commands;

namespace ExampleArchitecture.Core.CommandProcessor
{
    public class CommandProcessor : ICommandProcessor
    {
        private readonly ILifetimeScope _lifetimeScope;
        public CommandProcessor(ILifetimeScope lifetimeScope)
        {
            _lifetimeScope = lifetimeScope;
        }
        
        public void HandleCommand<TCommand>(TCommand command) where TCommand : ICommand
        {
            ICommandHandler<TCommand> handler = _lifetimeScope.Resolve<ICommandHandler<TCommand>>();
            handler.Handle(command);
        }
    }
}
