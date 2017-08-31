using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _StaticCalls_StaticCalls_
    {
        [OuterLoop]
        [Fact]
        public void _StaticCalls_StaticCalls_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\StaticCalls\\StaticCalls.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
