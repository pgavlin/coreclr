using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _MinMax_r_MinMax_r_
    {
        [Fact]
        public void _MinMax_r_MinMax_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\MinMax_r\\MinMax_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
