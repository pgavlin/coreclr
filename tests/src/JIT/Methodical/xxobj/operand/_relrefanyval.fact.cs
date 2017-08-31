using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _xxobj_operand__relrefanyval__relrefanyval_
    {
        [OuterLoop]
        [Fact]
        public void _xxobj_operand__relrefanyval__relrefanyval_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\xxobj\\operand\\_relrefanyval\\_relrefanyval.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
