using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _localloc_ehverify_eh13_large_eh13_large_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_ehverify_eh13_large_eh13_large_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\ehverify\\eh13_large\\eh13_large.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
