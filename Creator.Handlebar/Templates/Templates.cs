//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Creator.Handlebar.Templates
//{
//	public static class Templates
//	{
//		private static string usingTemplate = @""" 
//		using System;
//		using System.Collections.Generic;
//		using System.Linq;
//		using System.Text;
//		using MediatR;
//		""";
//		public static  string commandTemplate = usingTemplate + @"""

//		public class {{{name}}}Command: IRequest<Task>Request<Task>
//		{}""
//		";

//		public static  string commandHandlerTemplate = usingTemplate + @"
//		""public class {{name}}CommandHandler: IRequestHandler<{{name}}Command,Task>
//			{
//				public Task<Task> Handle({{name}}Command request,CancellationToken cancellationToken)
//				{
//					throw new NotImplementedException();
//				}
//			}
//			""";
//	}
//}
