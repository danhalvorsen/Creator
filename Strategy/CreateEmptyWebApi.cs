using System.Diagnostics;

namespace Creator.Strategy
{
    public class CreateEmptyWebApi : IProcessStarter
    {
        private readonly string webApiName;

        public CreateEmptyWebApi(string webApiName)
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
                Arguments = $"new project web --name {webApiName}"

            };
        }
    }


}

