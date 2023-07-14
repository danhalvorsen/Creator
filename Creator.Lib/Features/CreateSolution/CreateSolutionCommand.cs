using Creator.Lib.Model;
using MediatR;

namespace Creator.Lib.Features.CreateSolution {
	public class CreateSolutionCommand: IRequest<Task> {
		public IModel<CreateSolutionModel> SolutionModel { get; set; } = new CreateSolutionModel(string.Empty,string.Empty);
	}
}
