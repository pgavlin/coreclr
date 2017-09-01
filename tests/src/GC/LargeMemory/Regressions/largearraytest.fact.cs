using CoreclrTestLib;
using Xunit;

namespace GC_LargeMemory
{
    public class _Regressions_largearraytest_largearraytest_
    {
        [Fact]
        public void _Regressions_largearraytest_largearraytest_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\LargeMemory\\Regressions\\largearraytest\\largearraytest.cmd");
        }
    }
}
