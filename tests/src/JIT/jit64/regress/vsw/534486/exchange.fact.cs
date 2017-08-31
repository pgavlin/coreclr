using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _regress_vsw_534486_exchange_exchange_
    {
        [OuterLoop]
        [Fact]
        public void _regress_vsw_534486_exchange_exchange_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\regress\\vsw\\534486\\exchange\\exchange.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
