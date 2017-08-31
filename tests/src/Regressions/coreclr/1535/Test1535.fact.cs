using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    class _1535_Test1535_Test1535_
    {
        [OuterLoop]
        [Fact]
        public void _1535_Test1535_Test1535_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\coreclr\\1535\\Test1535\\Test1535.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
