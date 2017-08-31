using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_finallyexec_switchincatch_d_switchincatch_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_finallyexec_switchincatch_d_switchincatch_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\finallyexec\\switchincatch_d\\switchincatch_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
