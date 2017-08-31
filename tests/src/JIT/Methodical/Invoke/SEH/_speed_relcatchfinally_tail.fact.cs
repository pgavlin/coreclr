using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_SEH__speed_relcatchfinally_tail__speed_relcatchfinally_tail_
    {
        [Fact]
        public void _Invoke_SEH__speed_relcatchfinally_tail__speed_relcatchfinally_tail_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\SEH\\_speed_relcatchfinally_tail\\_speed_relcatchfinally_tail.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
