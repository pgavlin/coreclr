using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _forceinlining_Recursion_Recursion_
    {
        [OuterLoop]
        [Fact]
        public void _forceinlining_Recursion_Recursion_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\forceinlining\\Recursion\\Recursion.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
