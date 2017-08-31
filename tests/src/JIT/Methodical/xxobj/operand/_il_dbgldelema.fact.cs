using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _xxobj_operand__il_dbgldelema__il_dbgldelema_
    {
        [OuterLoop]
        [Fact]
        public void _xxobj_operand__il_dbgldelema__il_dbgldelema_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\xxobj\\operand\\_il_dbgldelema\\_il_dbgldelema.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
