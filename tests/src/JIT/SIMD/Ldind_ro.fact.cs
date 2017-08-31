using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _Ldind_ro_Ldind_ro_
    {
        [OuterLoop]
        [Fact]
        public void _Ldind_ro_Ldind_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\Ldind_ro\\Ldind_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
