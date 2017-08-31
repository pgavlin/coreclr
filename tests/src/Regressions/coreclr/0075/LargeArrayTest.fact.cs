using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    class _0075_LargeArrayTest_LargeArrayTest_
    {
        [OuterLoop]
        [Fact]
        public void _0075_LargeArrayTest_LargeArrayTest_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\coreclr\\0075\\LargeArrayTest\\LargeArrayTest.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
