using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _FPConvF2F_FPConvF2F_
    {
        [OuterLoop]
        [Fact]
        public void _FPConvF2F_FPConvF2F_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\FPConvF2F\\FPConvF2F.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
