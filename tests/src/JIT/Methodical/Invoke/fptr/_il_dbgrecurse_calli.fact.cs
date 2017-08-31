using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_fptr__il_dbgrecurse_calli__il_dbgrecurse_calli_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_fptr__il_dbgrecurse_calli__il_dbgrecurse_calli_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\fptr\\_il_dbgrecurse_calli\\_il_dbgrecurse_calli.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
