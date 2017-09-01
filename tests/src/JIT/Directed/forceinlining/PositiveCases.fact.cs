using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _forceinlining_PositiveCases_PositiveCases_
    {
        [OuterLoop]
        [Fact]
        public void _forceinlining_PositiveCases_PositiveCases_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\forceinlining\\PositiveCases\\PositiveCases.cmd");
        }
    }
}
