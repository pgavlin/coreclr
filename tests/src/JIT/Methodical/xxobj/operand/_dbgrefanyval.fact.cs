using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _xxobj_operand__dbgrefanyval__dbgrefanyval_
    {
        [OuterLoop]
        [Fact]
        public void _xxobj_operand__dbgrefanyval__dbgrefanyval_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\xxobj\\operand\\_dbgrefanyval\\_dbgrefanyval.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
