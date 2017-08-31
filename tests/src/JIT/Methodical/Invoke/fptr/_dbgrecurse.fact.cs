using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_fptr__dbgrecurse__dbgrecurse_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_fptr__dbgrecurse__dbgrecurse_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\fptr\\_dbgrecurse\\_dbgrecurse.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
