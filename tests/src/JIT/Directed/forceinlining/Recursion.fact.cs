using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _forceinlining_Recursion_Recursion_
    {
        [OuterLoop]
        [Fact]
        public void _forceinlining_Recursion_Recursion_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\forceinlining\\Recursion\\Recursion.cmd");
        }
    }
}
