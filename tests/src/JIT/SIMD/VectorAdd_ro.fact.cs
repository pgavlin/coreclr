using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _VectorAdd_ro_VectorAdd_ro_
    {
        [Fact]
        public void _VectorAdd_ro_VectorAdd_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\VectorAdd_ro\\VectorAdd_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
