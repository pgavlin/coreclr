using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _regress_ddb_127931_127931_127931_
    {
        [Fact]
        public void _regress_ddb_127931_127931_127931_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\regress\\ddb\\127931\\127931\\127931.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
