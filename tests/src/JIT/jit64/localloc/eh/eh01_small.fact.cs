using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _localloc_eh_eh01_small_eh01_small_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_eh_eh01_small_eh01_small_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\eh\\eh01_small\\eh01_small.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
