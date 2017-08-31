using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _regress_vsw_528315_simple_repro_simple_repro_
    {
        [OuterLoop]
        [Fact]
        public void _regress_vsw_528315_simple_repro_simple_repro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\regress\\vsw\\528315\\simple-repro\\simple-repro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
