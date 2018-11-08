using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExampleArchitecture.Mediator;
using Microsoft.AspNetCore.Authorization;

namespace ExampleArchitecture.Controllers
{
    public class ExampleController : BaseController
    {
        public ExampleController(IMediator mediator) : base(mediator)
        {

        }
    }
}
