using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _VectorCast_ro_VectorCast_ro_
    {
        [Fact]
        public void _VectorCast_ro_VectorCast_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\VectorCast_ro\\VectorCast_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
