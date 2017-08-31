using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _forceinlining_PositiveCases_PositiveCases_
    {
        [OuterLoop]
        [Fact]
        public void _forceinlining_PositiveCases_PositiveCases_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\forceinlining\\PositiveCases\\PositiveCases.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
