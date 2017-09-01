using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _regress_vsw_534486_exchange_exchange_
    {
        [OuterLoop]
        [Fact]
        public void _regress_vsw_534486_exchange_exchange_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\regress\\vsw\\534486\\exchange\\exchange.cmd");
        }
    }
}
