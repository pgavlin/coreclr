using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _localloc_verify_verify01_large_verify01_large_
    {
        [Fact]
        public void _localloc_verify_verify01_large_verify01_large_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\localloc\\verify\\verify01_large\\verify01_large.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
