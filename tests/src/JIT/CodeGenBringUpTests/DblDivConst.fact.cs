using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _DblDivConst_DblDivConst_
    {
        [OuterLoop]
        [Fact]
        public void _DblDivConst_DblDivConst_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\DblDivConst\\DblDivConst.cmd");
        }
    }
}
