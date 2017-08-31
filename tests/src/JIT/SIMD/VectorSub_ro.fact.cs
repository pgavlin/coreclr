using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _VectorSub_ro_VectorSub_ro_
    {
        [Fact]
        public void _VectorSub_ro_VectorSub_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\VectorSub_ro\\VectorSub_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
