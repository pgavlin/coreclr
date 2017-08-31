using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _VectorArgs_ro_VectorArgs_ro_
    {
        [Fact]
        public void _VectorArgs_ro_VectorArgs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\VectorArgs_ro\\VectorArgs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
