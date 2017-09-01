using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _UDivConst_UDivConst_
    {
        [Fact]
        public void _UDivConst_UDivConst_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\UDivConst\\UDivConst.cmd");
        }
    }
}
