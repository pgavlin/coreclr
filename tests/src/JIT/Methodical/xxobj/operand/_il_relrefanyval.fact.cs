using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _xxobj_operand__il_relrefanyval__il_relrefanyval_
    {
        [OuterLoop]
        [Fact]
        public void _xxobj_operand__il_relrefanyval__il_relrefanyval_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\xxobj\\operand\\_il_relrefanyval\\_il_relrefanyval.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
