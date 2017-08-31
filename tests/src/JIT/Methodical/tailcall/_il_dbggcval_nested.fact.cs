using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _tailcall__il_dbggcval_nested__il_dbggcval_nested_
    {
        [Fact]
        public void _tailcall__il_dbggcval_nested__il_dbggcval_nested_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\tailcall\\_il_dbggcval_nested\\_il_dbggcval_nested.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
