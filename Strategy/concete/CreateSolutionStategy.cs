using System.Diagnostics;

namespace Creator.Strategy.concete
{
    public class CreateSolutionStategy : AbstractProcessStrategy
    {
        private readonly string solutionName;

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSolutionStategy"/> class.
        /// 
        /// </summary>
        /// <param name="arguments">The arguments. Should be </param>
        public CreateSolutionStategy(string arguments)
        {
            solutionName = arguments;
        }

        public override string Arguments()
        {

            return $"new sln --name {solutionName}";
            ;
        }

        //public ProcessStartInfo Info
        //{
        //    get => new ProcessStartInfo
        //    {
        //        CreateNoWindow = true,
        //        UseShellExecute = true,
        //        WorkingDirectory = "C:\\Program Files\\dotnet\\",
        //        FileName = "dotnet.exe",
        //        WindowStyle = ProcessWindowStyle.Hidden,
        //        Arguments = $"new sln --name {this.SolutionName}"

        //    };
    }


}
