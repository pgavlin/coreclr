using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _FPConvF2Lng_FPConvF2Lng_
    {
        [OuterLoop]
        [Fact]
        public void _FPConvF2Lng_FPConvF2Lng_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\FPConvF2Lng\\FPConvF2Lng.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
