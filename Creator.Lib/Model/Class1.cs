using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creator.Lib.Model
{
	public class FolderModelValidator: AbstractValidator<FolderModel>
	{
        public FolderModelValidator()
        {
      RuleFor(x => x.Name).NotEmpty().NotNull().MinimumLength(4).WithMessage("The {PropertyName} is not valid");
			RuleFor(x => x.RelativePath).Must(ValidPathName).WithMessage("The {PropertyName} is not valid");

		}

		//'./a/b/c'
		private bool ValidPathName(string path)
		{
			var chars = path.ToCharArray();
			if (chars[0] != '.')
				return false;
			var splitted = path.Split(@"/");
			return splitted.Length <= 0 ? true : false;
		}
	}
}
