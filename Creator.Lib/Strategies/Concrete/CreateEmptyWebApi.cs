namespace Application.Strategy.Concrete
{
	public class CreateEmptyWebApiStrategy: DotNetAbstractProcessStarter
	{
		private readonly string projectName;

		public CreateEmptyWebApiStrategy(string projectName)
		{
			this.projectName = projectName;
		}

		public string WebApiName => projectName;

		public override string Arguments()
		{
			return $"new project web --name {projectName}";
		}
	}

}

