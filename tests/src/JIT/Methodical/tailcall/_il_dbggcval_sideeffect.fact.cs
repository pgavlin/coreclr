using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _tailcall__il_dbggcval_sideeffect__il_dbggcval_sideeffect_
    {
        [Fact]
        public void _tailcall__il_dbggcval_sideeffect__il_dbggcval_sideeffect_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\tailcall\\_il_dbggcval_sideeffect\\_il_dbggcval_sideeffect.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
