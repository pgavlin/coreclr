using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _AbsGeneric_r_AbsGeneric_r_
    {
        [Fact]
        public void _AbsGeneric_r_AbsGeneric_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\AbsGeneric_r\\AbsGeneric_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
