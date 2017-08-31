using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_SEH__speed_relcatchfinally__speed_relcatchfinally_
    {
        [Fact]
        public void _Invoke_SEH__speed_relcatchfinally__speed_relcatchfinally_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\SEH\\_speed_relcatchfinally\\_speed_relcatchfinally.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
