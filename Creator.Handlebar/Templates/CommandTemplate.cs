namespace Creator.Handlebar.Templates {
	public class CommandTemplate: ITemplate {

		public string CSCode { get => CreateCSCode(); }

		private string CreateCSCode() {
			return @"""
		public class {{{name}}}Command: IRequest<Task>
		{}""";
		}

		public string TSCode { get => CreateTSCode(); }

		private string CreateTSCode() {
			return @"""
		
		public class {{{name}}}Command: IRequest<Task>
		{}""";
		}

		private string cSTemplate = @"""
		public class {{{name}}}Command: IRequest<Task>
		{}""
		";

	}
}
