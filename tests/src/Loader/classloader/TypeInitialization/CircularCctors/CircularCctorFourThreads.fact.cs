using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    public class _TypeInitialization_CircularCctors_CircularCctorFourThreads_CircularCctorFourThreads_
    {
        [OuterLoop]
        [Fact]
        public void _TypeInitialization_CircularCctors_CircularCctorFourThreads_CircularCctorFourThreads_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Loader\\classloader\\TypeInitialization\\CircularCctors\\CircularCctorFourThreads\\CircularCctorFourThreads.cmd");
        }
    }
}
