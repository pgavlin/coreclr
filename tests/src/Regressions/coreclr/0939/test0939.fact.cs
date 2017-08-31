using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    class _0939_test0939_test0939_
    {
        [OuterLoop]
        [Fact]
        public void _0939_test0939_test0939_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\coreclr\\0939\\test0939\\test0939.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
