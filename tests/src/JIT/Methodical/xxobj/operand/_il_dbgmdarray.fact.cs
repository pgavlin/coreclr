using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _xxobj_operand__il_dbgmdarray__il_dbgmdarray_
    {
        [OuterLoop]
        [Fact]
        public void _xxobj_operand__il_dbgmdarray__il_dbgmdarray_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\xxobj\\operand\\_il_dbgmdarray\\_il_dbgmdarray.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
