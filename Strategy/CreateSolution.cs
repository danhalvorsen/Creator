using System.Diagnostics;

namespace Creator.Strategy
{
    public class CreateSolution : IProcessStarter
    {
        private readonly string solutionName;

        public CreateSolution(string solutionName)
        {
            this.solutionName = solutionName;
        }

        public ProcessStartInfo Info
        {
            get => new ProcessStartInfo
            {
                CreateNoWindow = true,
                UseShellExecute = true,
                WorkingDirectory = "C:\\Program Files\\dotnet\\",
                FileName = "dotnet.exe",
                WindowStyle = ProcessWindowStyle.Hidden,
                Arguments = $"new sln --name {this.solutionName}"

            };
        }
    }


}

