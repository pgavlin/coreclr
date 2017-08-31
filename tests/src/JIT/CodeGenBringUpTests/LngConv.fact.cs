using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _LngConv_LngConv_
    {
        [OuterLoop]
        [Fact]
        public void _LngConv_LngConv_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\LngConv\\LngConv.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
