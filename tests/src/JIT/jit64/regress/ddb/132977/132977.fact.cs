using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _regress_ddb_132977_132977_132977_
    {
        [OuterLoop]
        [Fact]
        public void _regress_ddb_132977_132977_132977_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\regress\\ddb\\132977\\132977\\132977.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
