using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _VectorSet_ro_VectorSet_ro_
    {
        [Fact]
        public void _VectorSet_ro_VectorSet_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\VectorSet_ro\\VectorSet_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
