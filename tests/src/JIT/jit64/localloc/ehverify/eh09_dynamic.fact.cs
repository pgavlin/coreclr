using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _localloc_ehverify_eh09_dynamic_eh09_dynamic_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_ehverify_eh09_dynamic_eh09_dynamic_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\ehverify\\eh09_dynamic\\eh09_dynamic.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
