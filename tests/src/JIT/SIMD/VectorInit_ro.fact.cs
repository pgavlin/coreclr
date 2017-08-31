using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _VectorInit_ro_VectorInit_ro_
    {
        [Fact]
        public void _VectorInit_ro_VectorInit_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\VectorInit_ro\\VectorInit_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
