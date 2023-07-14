using System.Diagnostics;

namespace Application.Strategy {
	public abstract class DotNetAbstractProcessStarter<T>: IProcessStrategy<T> {
		public abstract string Arguments();

		public void Execute() {
			using Process process = new Process();
			process.StartInfo = GetInfoStarter;
			Console.WriteLine("Starting process");
			process.Start();
			Console.WriteLine("Waiting for process to complete");
			process.WaitForExit();

		}

		public ProcessStartInfo GetInfoStarter {
			get => new ProcessStartInfo {
				CreateNoWindow = false,
				UseShellExecute = false,
				WorkingDirectory = "C:\\Program Files\\dotnet\\",
				FileName = "dotnet.exe",
				WindowStyle = ProcessWindowStyle.Hidden,
				Arguments = this.Arguments()

			};
		}

		//public string SolutionName => Arguments();

	}
}
