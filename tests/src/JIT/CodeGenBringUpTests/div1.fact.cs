using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _div1_div1_
    {
        [OuterLoop]
        [Fact]
        public void _div1_div1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\div1\\div1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
