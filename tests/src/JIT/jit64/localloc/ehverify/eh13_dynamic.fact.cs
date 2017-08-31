using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _localloc_ehverify_eh13_dynamic_eh13_dynamic_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_ehverify_eh13_dynamic_eh13_dynamic_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\ehverify\\eh13_dynamic\\eh13_dynamic.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
