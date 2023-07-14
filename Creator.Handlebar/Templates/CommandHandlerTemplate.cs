namespace Creator.Handlebar.Templates {
	public class CommandHandlerTemplate: ITemplate {
		public string CSCode { get => CreateCSCode(); }
		public string TSCode { get => CreateTSCode(); }

		private string CreateCSCode() =>
			@"""public class {{name}}CommandHandler: IRequestHandler<{{name}}Command,Task>
			{
				public Task<Task> Handle({{name}}Command command,CancellationToken cancellationToken)
				{
					throw new NotImplementedException();
				}
			}
			""";

		public string CreateTSCode() => @"
		""class {{name}}CommandHandler: IRequestHandler<{{name}}Command,Task>
			{
				public Task<Task> Handle({{name}}Command command,CancellationToken cancellationToken)
				{
					throw new NotImplementedException();
				}
			}
			""";
	}
}
