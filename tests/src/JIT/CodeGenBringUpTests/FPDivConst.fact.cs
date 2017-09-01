using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _FPDivConst_FPDivConst_
    {
        [OuterLoop]
        [Fact]
        public void _FPDivConst_FPDivConst_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\FPDivConst\\FPDivConst.cmd");
        }
    }
}
