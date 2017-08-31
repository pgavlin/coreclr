using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_finallyexec_loopinfinally_do_loopinfinally_do_
    {
        [Fact]
        public void _eh_finallyexec_loopinfinally_do_loopinfinally_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\finallyexec\\loopinfinally_do\\loopinfinally_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
