using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _FPMath_FPMath_
    {
        [OuterLoop]
        [Fact]
        public void _FPMath_FPMath_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\FPMath\\FPMath.cmd");
        }
    }
}
