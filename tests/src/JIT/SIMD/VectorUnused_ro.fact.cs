using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _VectorUnused_ro_VectorUnused_ro_
    {
        [Fact]
        public void _VectorUnused_ro_VectorUnused_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\VectorUnused_ro\\VectorUnused_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
