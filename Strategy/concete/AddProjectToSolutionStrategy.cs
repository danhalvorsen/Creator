using System.Diagnostics;

namespace Application.Strategy.concete
{
    public class AddProjectToSolutionStrategy : AbstractProcessStrategy
    {
        private readonly string webApiName;

        public AddProjectToSolutionStrategy(string webApiName)
        {
            this.webApiName = webApiName;
        }

        public string WebApiName => webApiName;

        public override string Arguments()
        {
            return $"sln add .\\{webApiName}\\{webApiName}.csproj";
        }
    }
}

