using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _FPMulConst_FPMulConst_
    {
        [OuterLoop]
        [Fact]
        public void _FPMulConst_FPMulConst_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\FPMulConst\\FPMulConst.cmd");
        }
    }
}
