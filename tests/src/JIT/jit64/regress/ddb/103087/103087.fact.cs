using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _regress_ddb_103087_103087_103087_
    {
        [OuterLoop]
        [Fact]
        public void _regress_ddb_103087_103087_103087_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\regress\\ddb\\103087\\103087\\103087.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
