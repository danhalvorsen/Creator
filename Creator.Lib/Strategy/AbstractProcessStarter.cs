using System.Diagnostics;

namespace Application.Strategy
{
	public abstract class AbstractProcessStrategy : IProcessStrategy
	{
		abstract public string Arguments();

		public void Execute()
		{
			using Process process = new Process();
			process.StartInfo = Info;
			Console.WriteLine("Starting process");
			process.Start();
			Console.WriteLine("Waiting for process to complete");
			process.WaitForExit();

		}

		public AbstractProcessStrategy(){}
																	  
		public ProcessStartInfo Info
		{
			get => new ProcessStartInfo
			{
				CreateNoWindow = false,
				UseShellExecute = false,
				WorkingDirectory = "C:\\Program Files\\dotnet\\",
				FileName = "dotnet.exe",
				WindowStyle = ProcessWindowStyle.Hidden,
				Arguments = this.Arguments()

			};
		}

		public string SolutionName => Arguments();
	}
}
