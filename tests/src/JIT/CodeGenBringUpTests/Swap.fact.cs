using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _Swap_Swap_
    {
        [OuterLoop]
        [Fact]
        public void _Swap_Swap_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\Swap\\Swap.cmd");
        }
    }
}
