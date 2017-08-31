using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _xxobj_operand__speed_dbgrefanyval__speed_dbgrefanyval_
    {
        [OuterLoop]
        [Fact]
        public void _xxobj_operand__speed_dbgrefanyval__speed_dbgrefanyval_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\xxobj\\operand\\_speed_dbgrefanyval\\_speed_dbgrefanyval.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
