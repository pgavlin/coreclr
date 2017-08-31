using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _regress_ddb_113574_113574_113574_
    {
        [OuterLoop]
        [Fact]
        public void _regress_ddb_113574_113574_113574_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\regress\\ddb\\113574\\113574\\113574.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
