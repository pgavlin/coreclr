using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _DivConst_DivConst_
    {
        [Fact]
        public void _DivConst_DivConst_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\DivConst\\DivConst.cmd");
        }
    }
}
