using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _xxobj_operand__il_dbgunbox__il_dbgunbox_
    {
        [OuterLoop]
        [Fact]
        public void _xxobj_operand__il_dbgunbox__il_dbgunbox_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\xxobj\\operand\\_il_dbgunbox\\_il_dbgunbox.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
