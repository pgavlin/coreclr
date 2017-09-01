using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _DblMulConst_DblMulConst_
    {
        [OuterLoop]
        [Fact]
        public void _DblMulConst_DblMulConst_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\DblMulConst\\DblMulConst.cmd");
        }
    }
}
