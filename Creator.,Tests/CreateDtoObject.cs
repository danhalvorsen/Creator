using Creator.Handlebar.Templates.Dto;

namespace Creator.Tests {
	[Collection("TemplateTestCollection")]
	public class CreateDtoTests {
		[Fact]
		public void Test1() {
			var properties = new PropertyDefinitions {
			new PropertyDefinition {
			Name = "Foo",
			Type = typeof(string),
			Value = "Hello"
			}
			};
			// Arrange
			DtoTemplate? x = new DtoTemplate("Foo",properties);

			var result = x.CreateCSCode();

			x.CreateFile(result);

		}

	}
}
