using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _FPAvg6_FPAvg6_
    {
        [OuterLoop]
        [Fact]
        public void _FPAvg6_FPAvg6_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\FPAvg6\\FPAvg6.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
