using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _forceinlining_NegativeCases_NegativeCases_
    {
        [Fact]
        public void _forceinlining_NegativeCases_NegativeCases_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\forceinlining\\NegativeCases\\NegativeCases.cmd");
        }
    }
}
