using CoreclrTestLib;
using Xunit;

namespace GC_Coverage
{
    class _LargeObjectAlloc_LargeObjectAlloc_
    {
        [Fact]
        public void _LargeObjectAlloc_LargeObjectAlloc_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Coverage\\LargeObjectAlloc\\LargeObjectAlloc.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
