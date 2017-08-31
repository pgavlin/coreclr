using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_finallyexec_switchincatch_do_switchincatch_do_
    {
        [OuterLoop]
        [Fact]
        public void _eh_finallyexec_switchincatch_do_switchincatch_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\finallyexec\\switchincatch_do\\switchincatch_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
