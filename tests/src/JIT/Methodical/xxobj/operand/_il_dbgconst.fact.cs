using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _xxobj_operand__il_dbgconst__il_dbgconst_
    {
        [OuterLoop]
        [Fact]
        public void _xxobj_operand__il_dbgconst__il_dbgconst_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\xxobj\\operand\\_il_dbgconst\\_il_dbgconst.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
