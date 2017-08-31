using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _localloc_ehverify_eh11_dynamic_eh11_dynamic_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_ehverify_eh11_dynamic_eh11_dynamic_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\ehverify\\eh11_dynamic\\eh11_dynamic.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
