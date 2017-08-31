using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _mul3_mul3_
    {
        [OuterLoop]
        [Fact]
        public void _mul3_mul3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\mul3\\mul3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
