using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _tailcall__il_dbgrecurse_ep__il_dbgrecurse_ep_
    {
        [Fact]
        public void _tailcall__il_dbgrecurse_ep__il_dbgrecurse_ep_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\tailcall\\_il_dbgrecurse_ep\\_il_dbgrecurse_ep.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
