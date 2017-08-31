using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _mul1_mul1_
    {
        [OuterLoop]
        [Fact]
        public void _mul1_mul1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\mul1\\mul1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
