using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _div2_div2_
    {
        [Fact]
        public void _div2_div2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\div2\\div2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
