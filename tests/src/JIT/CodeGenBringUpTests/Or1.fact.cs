using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _Or1_Or1_
    {
        [OuterLoop]
        [Fact]
        public void _Or1_Or1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\Or1\\Or1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
