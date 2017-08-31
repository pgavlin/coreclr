using CoreclrTestLib;
using Xunit;

namespace GC_Coverage
{
    class _LargeObjectAlloc2_LargeObjectAlloc2_
    {
        [Fact]
        public void _LargeObjectAlloc2_LargeObjectAlloc2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Coverage\\LargeObjectAlloc2\\LargeObjectAlloc2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
