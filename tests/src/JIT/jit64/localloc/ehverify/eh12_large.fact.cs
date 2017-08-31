using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _localloc_ehverify_eh12_large_eh12_large_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_ehverify_eh12_large_eh12_large_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\ehverify\\eh12_large\\eh12_large.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
