using Creator.Lib.Model;
using MediatR;

namespace Creator.Lib.Features.CreateSolution
{
	public class CreateSolutionCommand: IRequest<Task>
    {
      public IModel SolutionModel { get; set; } = new CreateSolutionModel();
    }
}
