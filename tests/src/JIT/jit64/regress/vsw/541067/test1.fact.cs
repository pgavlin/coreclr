using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _regress_vsw_541067_test1_test1_
    {
        [OuterLoop]
        [Fact]
        public void _regress_vsw_541067_test1_test1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\regress\\vsw\\541067\\test1\\test1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
