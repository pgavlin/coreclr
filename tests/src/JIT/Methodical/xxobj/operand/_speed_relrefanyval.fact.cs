using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _xxobj_operand__speed_relrefanyval__speed_relrefanyval_
    {
        [OuterLoop]
        [Fact]
        public void _xxobj_operand__speed_relrefanyval__speed_relrefanyval_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\xxobj\\operand\\_speed_relrefanyval\\_speed_relrefanyval.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
