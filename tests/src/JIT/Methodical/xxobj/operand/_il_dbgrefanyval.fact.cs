using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _xxobj_operand__il_dbgrefanyval__il_dbgrefanyval_
    {
        [OuterLoop]
        [Fact]
        public void _xxobj_operand__il_dbgrefanyval__il_dbgrefanyval_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\xxobj\\operand\\_il_dbgrefanyval\\_il_dbgrefanyval.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
