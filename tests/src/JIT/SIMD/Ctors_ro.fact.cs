using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _Ctors_ro_Ctors_ro_
    {
        [Fact]
        public void _Ctors_ro_Ctors_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\Ctors_ro\\Ctors_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
