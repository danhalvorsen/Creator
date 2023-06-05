using FluentValidation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
