using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _mul2_mul2_
    {
        [OuterLoop]
        [Fact]
        public void _mul2_mul2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\mul2\\mul2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
