using System.Diagnostics;

namespace Application.Strategy.concete
{
	public class CreateSolutionStrategy: AbstractProcessStrategy
	{
		private readonly string solutionName;

		/// <summary>
		/// Initializes a new instance of the <see cref="CreateSolutionStrategy"/> class.
		/// 
		/// </summary>
		/// <param name="arguments">The arguments. Should be </param>
		public CreateSolutionStrategy(string arguments)
		{
			solutionName = arguments;
		}

		public override string Arguments()
		{
			return $"new sln --name {solutionName}";
			;
		}
	}

}
