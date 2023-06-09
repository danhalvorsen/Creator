using MediatR;

namespace Creator.Lib.Features.CreateSolution
{
	public class CreateSolutionCommandHandler: IRequestHandler<CreateSolutionCommand,Task>
	{
		private CreateSolutionStrategy createSolutionStrategy;
		public CreateSolutionCommandHandler(CreateSolutionStrategy processStrategy)
		{
			this.createSolutionStrategy = processStrategy;
		}
		public Task<Task> Handle(CreateSolutionCommand request,CancellationToken cancellationToken)
		{
			createSolutionStrategy.Configuration = request.SolutionModel;
			createSolutionStrategy.Execute();
			return (Task<Task>)Task.CompletedTask;
		}
	}
}
