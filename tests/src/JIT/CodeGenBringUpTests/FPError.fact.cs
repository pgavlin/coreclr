using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _FPError_FPError_
    {
        [OuterLoop]
        [Fact]
        public void _FPError_FPError_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\FPError\\FPError.cmd");
        }
    }
}
