using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_fptr__speed_dbgrecurse__speed_dbgrecurse_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_fptr__speed_dbgrecurse__speed_dbgrecurse_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\fptr\\_speed_dbgrecurse\\_speed_dbgrecurse.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
