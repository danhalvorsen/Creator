
using Creator.Lib.Model;
using FluentValidation;

namespace Creator.Lib.Features.CreateSolution
{
	public class CreateSolutionCommandValidator: AbstractValidator<SolutionModel>
	{
		public CreateSolutionCommandValidator()
		{
			RuleFor(x => x).SetValidator(new SolutionModelValidator());
		}
	}
}
