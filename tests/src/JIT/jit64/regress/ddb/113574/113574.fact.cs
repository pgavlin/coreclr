using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _regress_ddb_113574_113574_113574_
    {
        [OuterLoop]
        [Fact]
        public void _regress_ddb_113574_113574_113574_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\regress\\ddb\\113574\\113574\\113574.cmd");
        }
    }
}
