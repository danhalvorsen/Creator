using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creator.Lib.Features.CreateSolution
{
	public class CreateSolutionCommandHandler: IRequestHandler<CreateSolutionCommand,Task>
	{
		public Task<Task> Handle(CreateSolutionCommand request,CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}
	}
}
