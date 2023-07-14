using Application.Strategy;
using Creator.Lib.Model;

namespace Creator.Lib.Features.CreateSolution {
	public class CreateSolutionStrategy: DotNetAbstractProcessStarter<ProcessStrategy> {
		public IModel<CreateSolutionModel> Configuration;

		//private readonly string solutionName;

		/// <summary>
		/// Initializes a new instance of the <see cref="CreateSolutionStrategy"/> class.
		/// 
		/// </summary>
		/// <param name="solutionName">The arguments. Should be the name of solution </param>
		public CreateSolutionStrategy(IModel<CreateSolutionModel> solutionModel) {
			this.Configuration = solutionModel;
		}

		public override string Arguments() {

			return $"new sln --name {Configuration.Config.SolutionName}";

		}
	}

}
