using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    class _1549_Test1549_Test1549_
    {
        [OuterLoop]
        [Fact]
        public void _1549_Test1549_Test1549_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\coreclr\\1549\\Test1549\\Test1549.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
