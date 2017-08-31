using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    class _1534_Test1534_Test1534_
    {
        [OuterLoop]
        [Fact]
        public void _1534_Test1534_Test1534_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\coreclr\\1534\\Test1534\\Test1534.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
