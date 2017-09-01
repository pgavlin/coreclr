using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _FPConvF2I_FPConvF2I_
    {
        [OuterLoop]
        [Fact]
        public void _FPConvF2I_FPConvF2I_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\FPConvF2I\\FPConvF2I.cmd");
        }
    }
}
