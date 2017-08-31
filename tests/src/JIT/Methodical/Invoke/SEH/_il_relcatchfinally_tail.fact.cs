using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_SEH__il_relcatchfinally_tail__il_relcatchfinally_tail_
    {
        [Fact]
        public void _Invoke_SEH__il_relcatchfinally_tail__il_relcatchfinally_tail_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\SEH\\_il_relcatchfinally_tail\\_il_relcatchfinally_tail.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
