using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_coverage__il_dbgcastclass_call__il_dbgcastclass_call_
    {
        [Fact]
        public void _casts_coverage__il_dbgcastclass_call__il_dbgcastclass_call_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\coverage\\_il_dbgcastclass_call\\_il_dbgcastclass_call.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
