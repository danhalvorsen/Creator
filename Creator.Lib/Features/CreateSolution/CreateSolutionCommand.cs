using Creator.Lib.Model;
using MediatR;
using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creator.Lib.Features.CreateSolution
{
    public class CreateSolutionCommand: IRequest<Task>
    {
      public SolutionModel Model { get; set; } = new SolutionModel();
    }
}
