using FluentValidation;

namespace Creator.Lib.Model
{
	public class SolutionModelValidator: AbstractValidator<CreateSolutionModel>
	{
		public SolutionModelValidator()
		{
			RuleFor(x => x.Name).NotEmpty().NotNull().MinimumLength(4).MaximumLength(200).WithMessage("{ProperytyName} is not valid");
			RuleFor(x => x.RootDirectory).Must(x => Path.Exists(x)).WithMessage("{PropertyName} is not a valid directory");
		}

	}
}
