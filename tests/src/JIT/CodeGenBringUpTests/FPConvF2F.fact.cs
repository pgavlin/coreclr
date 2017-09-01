using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _FPConvF2F_FPConvF2F_
    {
        [OuterLoop]
        [Fact]
        public void _FPConvF2F_FPConvF2F_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\FPConvF2F\\FPConvF2F.cmd");
        }
    }
}
