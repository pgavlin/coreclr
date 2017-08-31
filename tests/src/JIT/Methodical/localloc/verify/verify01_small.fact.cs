using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _localloc_verify_verify01_small_verify01_small_
    {
        [Fact]
        public void _localloc_verify_verify01_small_verify01_small_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\localloc\\verify\\verify01_small\\verify01_small.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
