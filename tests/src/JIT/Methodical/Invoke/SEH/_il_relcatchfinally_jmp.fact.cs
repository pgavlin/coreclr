using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_SEH__il_relcatchfinally_jmp__il_relcatchfinally_jmp_
    {
        [Fact]
        public void _Invoke_SEH__il_relcatchfinally_jmp__il_relcatchfinally_jmp_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\SEH\\_il_relcatchfinally_jmp\\_il_relcatchfinally_jmp.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
