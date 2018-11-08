using ExampleDomain.Commands;
using ExampleDomain.Queries;

namespace ExampleArchitecture.Mediator
{
    public interface IMediator
    {
        void ExecuteCommand<TCommand>(TCommand command) where TCommand : ICommand;
        TResult ExecuteQuery<TQuery, TResult>(TQuery query) where TQuery : IQuery<TResult>;
    }
}
