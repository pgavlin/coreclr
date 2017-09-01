using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    public class _regressions_421439_Test_Test_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_421439_Test_Test_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\421439\\Test\\Test.cmd");
        }
    }
}
