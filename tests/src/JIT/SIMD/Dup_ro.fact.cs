using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _Dup_ro_Dup_ro_
    {
        [Fact]
        public void _Dup_ro_Dup_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\Dup_ro\\Dup_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
