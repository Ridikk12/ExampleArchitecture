using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Example.Application.CommandHandlers;
using ExampleArchitecture.Core.CommandProcessor;
using ExampleArchitecture.Core.QueryProcessor;
using ExampleDomain.Commands;
using ExampleDomain.Queries;

namespace ExampleArchitecture.Mediator
{
    public class ExampleMediator : IMediator
    {
        private readonly ICommandProcessor _commandProcessor;
        private readonly IQueryProcessor _queryProcessor;

        public ExampleMediator(ICommandProcessor commandProcessor, IQueryProcessor queryProcessor)
        {
            _commandProcessor = commandProcessor;
            _queryProcessor = queryProcessor;
        }

        public void ExecuteCommand<TCommand>(TCommand command) where TCommand : ICommand => _commandProcessor.HandleCommand(command);


        public TResult ExecuteQuery<TQuery, TResult>(TQuery query) where TQuery : IQuery<TResult>
        {
            return _queryProcessor.Run<TQuery,TResult>(query);
        }
    }
}
