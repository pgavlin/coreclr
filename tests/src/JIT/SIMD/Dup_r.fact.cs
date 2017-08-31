using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _Dup_r_Dup_r_
    {
        [Fact]
        public void _Dup_r_Dup_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\Dup_r\\Dup_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
