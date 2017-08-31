using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _forceinlining_NegativeCases_NegativeCases_
    {
        [Fact]
        public void _forceinlining_NegativeCases_NegativeCases_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\forceinlining\\NegativeCases\\NegativeCases.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
