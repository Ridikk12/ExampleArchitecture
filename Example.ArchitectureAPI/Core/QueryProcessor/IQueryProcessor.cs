using ExampleDomain.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleArchitecture.Core.QueryProcessor
{
    public interface IQueryProcessor
    {
        TResult Run<TQuery, TResult>(TQuery query) where TQuery : IQuery<TResult>;


    }
}
