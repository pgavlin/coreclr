using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _localloc_ehverify_eh12_dynamic_eh12_dynamic_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_ehverify_eh12_dynamic_eh12_dynamic_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\ehverify\\eh12_dynamic\\eh12_dynamic.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
