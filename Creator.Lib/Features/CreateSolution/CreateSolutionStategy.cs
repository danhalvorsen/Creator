using System.Diagnostics;
using Application.Strategy;

namespace Creator.Lib.Features.CreateSolution
{
    public class CreateSolutionStrategy : DotNetAbstractProcessStarter
    {
        private readonly string solutionName;

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSolutionStrategy"/> class.
        /// 
        /// </summary>
        /// <param name="solutionName">The arguments. Should be the name of solution </param>
        public CreateSolutionStrategy(string solutionName)
        {
            this.solutionName = solutionName;
        }

        public override string Arguments()
        {
            return $"new sln --name {solutionName}";
            ;
        }
    }

}
