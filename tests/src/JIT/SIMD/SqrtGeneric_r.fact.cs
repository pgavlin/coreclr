using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _SqrtGeneric_r_SqrtGeneric_r_
    {
        [Fact]
        public void _SqrtGeneric_r_SqrtGeneric_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\SqrtGeneric_r\\SqrtGeneric_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
