using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _VectorArrayInit_ro_VectorArrayInit_ro_
    {
        [Fact]
        public void _VectorArrayInit_ro_VectorArrayInit_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\VectorArrayInit_ro\\VectorArrayInit_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
