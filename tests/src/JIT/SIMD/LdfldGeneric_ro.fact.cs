using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _LdfldGeneric_ro_LdfldGeneric_ro_
    {
        [Fact]
        public void _LdfldGeneric_ro_LdfldGeneric_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\LdfldGeneric_ro\\LdfldGeneric_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
