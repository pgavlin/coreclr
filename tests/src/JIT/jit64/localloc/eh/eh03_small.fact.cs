using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _localloc_eh_eh03_small_eh03_small_
    {
        [Fact]
        public void _localloc_eh_eh03_small_eh03_small_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\eh\\eh03_small\\eh03_small.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
