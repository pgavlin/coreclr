using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _CtorFromArray_ro_CtorFromArray_ro_
    {
        [Fact]
        public void _CtorFromArray_ro_CtorFromArray_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\CtorFromArray_ro\\CtorFromArray_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
