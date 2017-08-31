using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _regress_asurt_143616_foo_foo_
    {
        [OuterLoop]
        [Fact]
        public void _regress_asurt_143616_foo_foo_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\regress\\asurt\\143616\\foo\\foo.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
