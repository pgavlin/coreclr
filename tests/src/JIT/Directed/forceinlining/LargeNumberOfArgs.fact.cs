using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _forceinlining_LargeNumberOfArgs_LargeNumberOfArgs_
    {
        [OuterLoop]
        [Fact]
        public void _forceinlining_LargeNumberOfArgs_LargeNumberOfArgs_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\forceinlining\\LargeNumberOfArgs\\LargeNumberOfArgs.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
