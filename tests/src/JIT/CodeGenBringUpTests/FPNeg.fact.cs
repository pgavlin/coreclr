using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _FPNeg_FPNeg_
    {
        [OuterLoop]
        [Fact]
        public void _FPNeg_FPNeg_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\FPNeg\\FPNeg.cmd");
        }
    }
}
