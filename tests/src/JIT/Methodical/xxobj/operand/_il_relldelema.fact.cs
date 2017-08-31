using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _xxobj_operand__il_relldelema__il_relldelema_
    {
        [OuterLoop]
        [Fact]
        public void _xxobj_operand__il_relldelema__il_relldelema_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\xxobj\\operand\\_il_relldelema\\_il_relldelema.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
