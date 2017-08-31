using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _DivSignedUnsignedTest_r_DivSignedUnsignedTest_r_
    {
        [Fact]
        public void _DivSignedUnsignedTest_r_DivSignedUnsignedTest_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\DivSignedUnsignedTest_r\\DivSignedUnsignedTest_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
