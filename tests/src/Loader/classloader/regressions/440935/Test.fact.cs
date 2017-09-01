using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    public class _regressions_440935_Test_Test_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_440935_Test_Test_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\440935\\Test\\Test.cmd");
        }
    }
}
