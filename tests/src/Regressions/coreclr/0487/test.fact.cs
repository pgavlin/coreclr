using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    class _0487_test_test_
    {
        [OuterLoop]
        [Fact]
        public void _0487_test_test_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\coreclr\\0487\\test\\test.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
