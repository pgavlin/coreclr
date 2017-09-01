using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _FPMul_FPMul_
    {
        [OuterLoop]
        [Fact]
        public void _FPMul_FPMul_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\FPMul\\FPMul.cmd");
        }
    }
}
