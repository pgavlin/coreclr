using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _localloc_ehverify_eh07_dynamic_eh07_dynamic_
    {
        [Fact]
        public void _localloc_ehverify_eh07_dynamic_eh07_dynamic_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\ehverify\\eh07_dynamic\\eh07_dynamic.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
