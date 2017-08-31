using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _localloc_verify_verify01_dynamic_verify01_dynamic_
    {
        [Fact]
        public void _localloc_verify_verify01_dynamic_verify01_dynamic_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\localloc\\verify\\verify01_dynamic\\verify01_dynamic.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
