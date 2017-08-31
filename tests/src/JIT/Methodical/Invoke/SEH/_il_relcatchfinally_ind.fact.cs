using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_SEH__il_relcatchfinally_ind__il_relcatchfinally_ind_
    {
        [Fact]
        public void _Invoke_SEH__il_relcatchfinally_ind__il_relcatchfinally_ind_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\SEH\\_il_relcatchfinally_ind\\_il_relcatchfinally_ind.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
