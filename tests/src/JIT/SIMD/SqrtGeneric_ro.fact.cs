using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _SqrtGeneric_ro_SqrtGeneric_ro_
    {
        [Fact]
        public void _SqrtGeneric_ro_SqrtGeneric_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\SqrtGeneric_ro\\SqrtGeneric_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
