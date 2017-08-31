using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_finallyexec_loopinfinally_ro_loopinfinally_ro_
    {
        [Fact]
        public void _eh_finallyexec_loopinfinally_ro_loopinfinally_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\finallyexec\\loopinfinally_ro\\loopinfinally_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
