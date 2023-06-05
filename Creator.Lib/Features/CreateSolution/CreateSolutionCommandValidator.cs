
// Ignore Spelling: Validator

using Creator.Lib.Model;
using FluentValidation;

namespace Creator.Lib.Features.CreateSolution
{
	public class CreateSolutionCommandValidator: AbstractValidator<CreateSolutionModel>
	{
		public CreateSolutionCommandValidator()
		{
			RuleFor(x => x).SetValidator(new SolutionModelValidator());
		}
	}
}
