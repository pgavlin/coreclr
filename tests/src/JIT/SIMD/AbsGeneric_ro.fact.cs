using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _AbsGeneric_ro_AbsGeneric_ro_
    {
        [Fact]
        public void _AbsGeneric_ro_AbsGeneric_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\AbsGeneric_ro\\AbsGeneric_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
