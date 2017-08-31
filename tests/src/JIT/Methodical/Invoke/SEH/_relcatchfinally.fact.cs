using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_SEH__relcatchfinally__relcatchfinally_
    {
        [Fact]
        public void _Invoke_SEH__relcatchfinally__relcatchfinally_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\SEH\\_relcatchfinally\\_relcatchfinally.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
