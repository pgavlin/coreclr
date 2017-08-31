using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _xxobj_operand__il_relunbox__il_relunbox_
    {
        [OuterLoop]
        [Fact]
        public void _xxobj_operand__il_relunbox__il_relunbox_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\xxobj\\operand\\_il_relunbox\\_il_relunbox.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
