using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _DblNeg_DblNeg_
    {
        [OuterLoop]
        [Fact]
        public void _DblNeg_DblNeg_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\DblNeg\\DblNeg.cmd");
        }
    }
}
