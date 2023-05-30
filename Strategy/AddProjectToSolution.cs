using System.Diagnostics;

namespace Creator.Strategy
{
    public class AddProjectToSolution : IProcessStarter
    {
        private readonly string webApiName;

        public AddProjectToSolution(string solutionName, string webApiName)
        {
            this.webApiName = webApiName;
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
                Arguments = $"sln add .\\{webApiName}\\{}.csproj {webApiName}"

            };
        }
    }


}

