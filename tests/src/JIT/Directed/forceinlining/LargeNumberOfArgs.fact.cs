using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _forceinlining_LargeNumberOfArgs_LargeNumberOfArgs_
    {
        [OuterLoop]
        [Fact]
        public void _forceinlining_LargeNumberOfArgs_LargeNumberOfArgs_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\forceinlining\\LargeNumberOfArgs\\LargeNumberOfArgs.cmd");
        }
    }
}
