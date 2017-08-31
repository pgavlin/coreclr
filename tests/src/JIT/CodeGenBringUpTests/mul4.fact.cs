using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _mul4_mul4_
    {
        [OuterLoop]
        [Fact]
        public void _mul4_mul4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\mul4\\mul4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
