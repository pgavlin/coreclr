using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _NotAndNeg_NotAndNeg_
    {
        [OuterLoop]
        [Fact]
        public void _NotAndNeg_NotAndNeg_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\NotAndNeg\\NotAndNeg.cmd");
        }
    }
}
