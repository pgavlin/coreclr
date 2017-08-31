using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_SEH__il_relcatchfault__il_relcatchfault_
    {
        [Fact]
        public void _Invoke_SEH__il_relcatchfault__il_relcatchfault_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\SEH\\_il_relcatchfault\\_il_relcatchfault.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
