using Creator.API;
using Creator.Lib.Model;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Text.Json;
using Xunit.Abstractions;

namespace Creator.Tests {
	[Collection("IntegrationTests")]
	public class TestCreateSolutionWithWebApp: IClassFixture<WebApplicationFactory<Program>> {
		private WebApplicationFactory<Program> _testFixtureBase;
		private ITestOutputHelper _testOutputHelper;

		public TestCreateSolutionWithWebApp(
					 WebApplicationFactory<Program> testFixtureBase,
					 ITestOutputHelper testOutputHelper) {
			_testFixtureBase = testFixtureBase;
			_testOutputHelper = testOutputHelper;

			// Invoke the app

		}

		//Logic sits here after the application is invoked
		[Fact]
		public async Task Test1() {
			var client = _testFixtureBase.CreateDefaultClient();
			CreateSolutionModel? solutionModel = new CreateSolutionModel("Foo",@"c\:temp");
			var projects = new List<CreateProjectModel>
			{
				new CreateProjectModel("FooWebProject",
				new CreateFolderModel("tempFolder", @"./veryTemp"),
				solutionModel
				)
			};

			//var model = new CreateSolutionModel("TestModel",solution);

			//{ SolutionName = "FooName",ProjectName = "WebApp",WorkingDirectory = @"c:\temp\" };
			JsonSerializerOptions options = new(JsonSerializerDefaults.Web) {
				WriteIndented = true
			};

			var serializedModel = JsonSerializer.Serialize(solutionModel,options);
			var result = await client.PostAsync("/",
				new StringContent(serializedModel,System.Text.Encoding.UTF8,"application/json"));

		}

	}

}
