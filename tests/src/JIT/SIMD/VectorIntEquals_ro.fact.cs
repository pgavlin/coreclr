using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _VectorIntEquals_ro_VectorIntEquals_ro_
    {
        [Fact]
        public void _VectorIntEquals_ro_VectorIntEquals_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\VectorIntEquals_ro\\VectorIntEquals_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
