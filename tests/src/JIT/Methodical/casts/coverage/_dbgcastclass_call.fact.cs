using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_coverage__dbgcastclass_call__dbgcastclass_call_
    {
        [Fact]
        public void _casts_coverage__dbgcastclass_call__dbgcastclass_call_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\coverage\\_dbgcastclass_call\\_dbgcastclass_call.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
