using Creator.Strategy;
using Creator.Strategy.concete;
using System.Diagnostics;

namespace Creator
{
	internal class Program
	{
		//Creator --s solutionName --web WebApiName
		static void Main(string[] args)
		{
			Debug.Assert(args[1] != null || args[3] != null,"Invalid input to application");
			var solutionName = args[1];
			var webName = args[3];

			var strategies = new List<IProcessStrategy>
			{
				new CreateSolutionStategy(solutionName),
				new CreateEmptyWebApiStrategy(webName),
				new AddProjectToSolutionStrategy(webName)
		};

			new Worker(strategies).DoIt();
		}
	}
}