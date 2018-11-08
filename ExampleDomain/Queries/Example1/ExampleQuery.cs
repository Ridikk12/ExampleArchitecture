using Example.Domain.Queries.QueryResult;
using ExampleDomain.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Domain.Queries.Example1
{
    public class ExampleQuery : IQuery<ExampleQueryResult>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

    }
}
