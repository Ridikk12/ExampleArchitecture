using ExampleDomain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleArchitecture.Core.CommandProcessor
{
    public interface ICommandProcessor
    {
        void HandleCommand<T>(T command) where T : ICommand;
    }
}
