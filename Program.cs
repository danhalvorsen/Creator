using Application.Strategy;
using Application.Strategy.concete;
using Creator.Model;

namespace Application
{
	public class Program
	{
		//Creator --s solutionName --web WebApiName
		public static async Task Main(string[] args)
		{

			var builder = WebApplication.CreateBuilder(args);
			var app = builder.Build();
			//ToDo - Make a generic model for a wanted solution
			//ToDO - Do we really want an API here? Should choose between communication handler? CLI or API
			//CLI :>build solution --withModel model
			app.MapPost("/",(Model model) => {

				//Debug.Assert(args[1] != null || args[3] != null,"Invalid input to application");
				//validate the model //ToDo
				var solutionName = model.SolutionName;
				var webName = model.WebProjectName;

				var strategies = new List<IProcessStrategy>
			{
				new CreateSolutionStrategy(solutionName),
				new CreateEmptyWebApiStrategy(webName),
				new AddProjectToSolutionStrategy(webName)

				//Download the code as zipped files
				//https://blog.elmah.io/creating-and-downloading-zip-files-with-asp-net-core/
		};

				new CreatorWithThis(strategies).Create();

			});

			await app.RunAsync();

		}
		 
	}

}