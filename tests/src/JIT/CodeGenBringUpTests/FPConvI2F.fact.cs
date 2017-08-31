using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _FPConvI2F_FPConvI2F_
    {
        [OuterLoop]
        [Fact]
        public void _FPConvI2F_FPConvI2F_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\FPConvI2F\\FPConvI2F.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
