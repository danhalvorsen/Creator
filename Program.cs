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
		//	new CmdProcessStarter(solutionName,webName);




		}
	}
}