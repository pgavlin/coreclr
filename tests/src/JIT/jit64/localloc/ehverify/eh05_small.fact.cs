using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _localloc_ehverify_eh05_small_eh05_small_
    {
        [Fact]
        public void _localloc_ehverify_eh05_small_eh05_small_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\ehverify\\eh05_small\\eh05_small.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
