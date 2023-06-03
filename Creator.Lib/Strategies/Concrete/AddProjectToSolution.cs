using System.Diagnostics;

namespace Application.Strategy.Concrete
{
	public class AddProjectToSolution: DotNetAbstractProcessStarter
	{
		private readonly string projectName;

		public AddProjectToSolution(string projectName)
		{
			this.projectName = projectName;
		}

		public string ProjectName => projectName;

		public override string Arguments()
		{
			return $"sln add .\\{projectName}\\{projectName}.csproj";
		}
	}
}

