using System.Diagnostics;

namespace Application.Strategy.concete
{
	public class CreateEmptyWebApiStrategy: AbstractProcessStrategy
	{
		private readonly string webApiName;

		public CreateEmptyWebApiStrategy(string webApiName)
		{
			this.webApiName = webApiName;
		}

		public string WebApiName => webApiName;

		public override string Arguments()
		{
			return $"new project web --name {webApiName}";
		}
	}

}

