using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _VectorConvert_ro_VectorConvert_ro_
    {
        [Fact]
        public void _VectorConvert_ro_VectorConvert_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\VectorConvert_ro\\VectorConvert_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
