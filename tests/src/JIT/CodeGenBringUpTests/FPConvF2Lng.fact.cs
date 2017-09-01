using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _FPConvF2Lng_FPConvF2Lng_
    {
        [OuterLoop]
        [Fact]
        public void _FPConvF2Lng_FPConvF2Lng_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\FPConvF2Lng\\FPConvF2Lng.cmd");
        }
    }
}
