using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _CreateGeneric_ro_CreateGeneric_ro_
    {
        [Fact]
        public void _CreateGeneric_ro_CreateGeneric_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\CreateGeneric_ro\\CreateGeneric_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
