using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_finallyexec_switchincatch_ro_switchincatch_ro_
    {
        [OuterLoop]
        [Fact]
        public void _eh_finallyexec_switchincatch_ro_switchincatch_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\finallyexec\\switchincatch_ro\\switchincatch_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
