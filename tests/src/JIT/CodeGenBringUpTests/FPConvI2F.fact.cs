using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _FPConvI2F_FPConvI2F_
    {
        [OuterLoop]
        [Fact]
        public void _FPConvI2F_FPConvI2F_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\FPConvI2F\\FPConvI2F.cmd");
        }
    }
}
