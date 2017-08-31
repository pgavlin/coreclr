using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _DivSignedUnsignedTest_ro_DivSignedUnsignedTest_ro_
    {
        [Fact]
        public void _DivSignedUnsignedTest_ro_DivSignedUnsignedTest_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\DivSignedUnsignedTest_ro\\DivSignedUnsignedTest_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
