using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    class _1402_Test1402_Test1402_
    {
        [OuterLoop]
        [Fact]
        public void _1402_Test1402_Test1402_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\coreclr\\1402\\Test1402\\Test1402.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
