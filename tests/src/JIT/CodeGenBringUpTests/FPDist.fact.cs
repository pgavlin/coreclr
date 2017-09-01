using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _FPDist_FPDist_
    {
        [OuterLoop]
        [Fact]
        public void _FPDist_FPDist_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\FPDist\\FPDist.cmd");
        }
    }
}
