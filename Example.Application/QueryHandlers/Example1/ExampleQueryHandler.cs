using Example.Domain.Queries.Example1;
using Example.Domain.Queries.QueryResult;
using ExampleDomain.Queries;
using System;

namespace Example.Application.QueryHandlers.Example1
{
    public class ExampleQueryHandler : IQueryHandler<ExampleQuery, ExampleQueryResult>
    {
        public ExampleQueryHandler()
        {

        }

        public ExampleQueryResult Handle(IQuery<ExampleQueryResult> query)
        {
            return new ExampleQueryResult { Id = Guid.NewGuid(), Name = "Test" };
        }
    }
}
