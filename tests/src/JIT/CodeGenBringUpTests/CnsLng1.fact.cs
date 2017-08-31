using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _CnsLng1_CnsLng1_
    {
        [OuterLoop]
        [Fact]
        public void _CnsLng1_CnsLng1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\CnsLng1\\CnsLng1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
