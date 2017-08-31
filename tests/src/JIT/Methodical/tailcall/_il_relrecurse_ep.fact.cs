using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _tailcall__il_relrecurse_ep__il_relrecurse_ep_
    {
        [Fact]
        public void _tailcall__il_relrecurse_ep__il_relrecurse_ep_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\tailcall\\_il_relrecurse_ep\\_il_relrecurse_ep.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
