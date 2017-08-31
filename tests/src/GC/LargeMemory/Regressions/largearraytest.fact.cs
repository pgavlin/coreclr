using CoreclrTestLib;
using Xunit;

namespace GC_LargeMemory
{
    class _Regressions_largearraytest_largearraytest_
    {
        [Fact]
        public void _Regressions_largearraytest_largearraytest_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\LargeMemory\\Regressions\\largearraytest\\largearraytest.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
