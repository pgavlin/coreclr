using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _CtorFromArray_r_CtorFromArray_r_
    {
        [Fact]
        public void _CtorFromArray_r_CtorFromArray_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\CtorFromArray_r\\CtorFromArray_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
