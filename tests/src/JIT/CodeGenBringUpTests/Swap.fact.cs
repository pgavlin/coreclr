using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _Swap_Swap_
    {
        [OuterLoop]
        [Fact]
        public void _Swap_Swap_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\Swap\\Swap.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
