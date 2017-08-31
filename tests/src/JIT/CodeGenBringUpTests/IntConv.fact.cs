using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _IntConv_IntConv_
    {
        [OuterLoop]
        [Fact]
        public void _IntConv_IntConv_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\IntConv\\IntConv.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
