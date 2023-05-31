using Application;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Text.Json;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace Creator._Tests
{
	[Collection("IntegrationTests")]
	public class TestCreateSolutionWithWebApp: IClassFixture<WebApplicationFactory<Program>>
	{
		private WebApplicationFactory<Program> _testFixtureBase;
		private ITestOutputHelper _testOutputHelper;

		public TestCreateSolutionWithWebApp(
					 WebApplicationFactory<Program> testFixtureBase,
					 ITestOutputHelper testOutputHelper)
		{
			_testFixtureBase = testFixtureBase;
			_testOutputHelper = testOutputHelper;

			// Invoke the app

		}

		//Logic sits here after the application is invoked
		[Fact]
		public async Task Test1()
		{
			var client = _testFixtureBase.CreateDefaultClient();
			var model = new Model.Model
			{ SolutionName = "FooName",WebProjectName = "WebApp",WorkingDirectory = @"c:\temp\" };
			JsonSerializerOptions options = new(JsonSerializerDefaults.Web)
			{
				WriteIndented = true
			};

			var serializedModel = JsonSerializer.Serialize(model,options);
			var result = await client.PostAsync("/",
				new StringContent(serializedModel,System.Text.Encoding.UTF8,"application/json"));
				
		}

	}

}