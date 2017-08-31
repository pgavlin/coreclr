using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _xxobj_operand__dbgunbox__dbgunbox_
    {
        [OuterLoop]
        [Fact]
        public void _xxobj_operand__dbgunbox__dbgunbox_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\xxobj\\operand\\_dbgunbox\\_dbgunbox.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
