using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _MinMax_ro_MinMax_ro_
    {
        [Fact]
        public void _MinMax_ro_MinMax_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\MinMax_ro\\MinMax_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
