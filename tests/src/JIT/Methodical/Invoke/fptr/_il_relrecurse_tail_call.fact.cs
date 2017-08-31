using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_fptr__il_relrecurse_tail_call__il_relrecurse_tail_call_
    {
        [Fact]
        public void _Invoke_fptr__il_relrecurse_tail_call__il_relrecurse_tail_call_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\fptr\\_il_relrecurse_tail_call\\_il_relrecurse_tail_call.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
