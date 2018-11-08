using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Example.Application.QueryHandlers;
using ExampleDomain.Queries;

namespace ExampleArchitecture.Core.QueryProcessor
{
    public class QueryProcessor : IQueryProcessor
    {
        private readonly ILifetimeScope _lifetimeScope;
        public QueryProcessor(ILifetimeScope lifetimeScope)
        {
            _lifetimeScope = lifetimeScope;
        }

        public TResult Run<TQuery, TResult>(TQuery query) where TQuery : IQuery<TResult>
        {
            IQueryHandler<TQuery,TResult> queryHandler = _lifetimeScope.Resolve<IQueryHandler<TQuery, TResult>>();
            return queryHandler.Handle(query);
        }
    }
}
