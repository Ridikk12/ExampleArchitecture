using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleDomain.Commands.Example1
{
    public class ExampleCommand : ICommand
    {
        public string Name { get; private set; }

        public ExampleCommand(string name)
        {
            Name = name;
        }
    }
}
