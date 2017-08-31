using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _BugWithAVX_ro_BugWithAVX_ro_
    {
        [OuterLoop]
        [Fact]
        public void _BugWithAVX_ro_BugWithAVX_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\BugWithAVX_ro\\BugWithAVX_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
