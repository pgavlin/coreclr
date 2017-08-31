using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _VectorInitN_ro_VectorInitN_ro_
    {
        [Fact]
        public void _VectorInitN_ro_VectorInitN_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\VectorInitN_ro\\VectorInitN_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
