using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _VectorAbs_ro_VectorAbs_ro_
    {
        [Fact]
        public void _VectorAbs_ro_VectorAbs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\VectorAbs_ro\\VectorAbs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
