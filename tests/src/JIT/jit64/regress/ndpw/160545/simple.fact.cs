using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _regress_ndpw_160545_simple_simple_
    {
        [OuterLoop]
        [Fact]
        public void _regress_ndpw_160545_simple_simple_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\regress\\ndpw\\160545\\simple\\simple.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
