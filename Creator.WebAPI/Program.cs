using Application;
using Application.Strategy;
using Application.Strategy.Concrete;
using Creator.Lib.Features.CreateSolution;

namespace Creator.API
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
			//CLI :>build solution --wi|hModel model
			app.MapGet("/get",() => { return new Creator.Lib.Model.Model(); });

			app.MapPost("/",(Creator.Lib.Model.IModel model) =>
			{

				//Debug.Assert(args[1] != null || args[3] != null,"Invalid input to application");
				//validate the model //ToDo
				var solutionName = model.SolutionName;
				var webName = model.WebProjectName;

				var strategies = new List<IProcessStrategy>
			{
				new CreateSolutionStrategy(solutionName),
				new CreateEmptyWebApiStrategy(webName),
				new AddProjectToSolution(webName)

				//Download the code as zipped files
				//https://blog.elmah.io/creating-and-downloading-zip-files-with-asp-net-core/
		};

				new CreatorWithThis(strategies).Create();

				return Results.Ok();

			});

			await app.RunAsync();

		}

	}

}