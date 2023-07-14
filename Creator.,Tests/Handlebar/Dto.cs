using Creator.Handlebar.Templates.Handlebar;

namespace Creator.Tests {
	[Collection("HandlebarTest")]
	public class HandlebarTest {
		[Fact]
		public void Test() {
			var template = new DtoHandlebarTemplate();
			var result = template.Create();

		}

	}
}
