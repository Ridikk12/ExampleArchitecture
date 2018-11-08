using ExampleDomain.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Application.QueryHandlers
{
    public interface IQueryHandler<TQuery,TResult> 
        where TQuery : IQuery<TResult>
    {
        TResult Handle(IQuery<TResult> query);

    }
}
