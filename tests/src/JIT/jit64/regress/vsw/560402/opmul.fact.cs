using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _regress_vsw_560402_opmul_opmul_
    {
        [OuterLoop]
        [Fact]
        public void _regress_vsw_560402_opmul_opmul_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\regress\\vsw\\560402\\opmul\\opmul.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
