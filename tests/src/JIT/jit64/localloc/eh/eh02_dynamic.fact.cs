using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _localloc_eh_eh02_dynamic_eh02_dynamic_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_eh_eh02_dynamic_eh02_dynamic_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\eh\\eh02_dynamic\\eh02_dynamic.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
