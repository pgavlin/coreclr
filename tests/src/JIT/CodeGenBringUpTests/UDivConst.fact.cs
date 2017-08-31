using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _UDivConst_UDivConst_
    {
        [Fact]
        public void _UDivConst_UDivConst_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\UDivConst\\UDivConst.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
