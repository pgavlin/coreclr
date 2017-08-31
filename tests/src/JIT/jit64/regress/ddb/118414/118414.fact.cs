using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _regress_ddb_118414_118414_118414_
    {
        [OuterLoop]
        [Fact]
        public void _regress_ddb_118414_118414_118414_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\regress\\ddb\\118414\\118414\\118414.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
