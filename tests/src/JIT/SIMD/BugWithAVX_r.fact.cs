using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _BugWithAVX_r_BugWithAVX_r_
    {
        [OuterLoop]
        [Fact]
        public void _BugWithAVX_r_BugWithAVX_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\BugWithAVX_r\\BugWithAVX_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
