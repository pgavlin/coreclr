using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_SEH__il_dbgcatchfinally_ind__il_dbgcatchfinally_ind_
    {
        [Fact]
        public void _Invoke_SEH__il_dbgcatchfinally_ind__il_dbgcatchfinally_ind_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\SEH\\_il_dbgcatchfinally_ind\\_il_dbgcatchfinally_ind.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
