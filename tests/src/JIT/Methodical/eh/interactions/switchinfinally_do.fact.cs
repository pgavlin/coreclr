using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_interactions_switchinfinally_do_switchinfinally_do_
    {
        [Fact]
        public void _eh_interactions_switchinfinally_do_switchinfinally_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\interactions\\switchinfinally_do\\switchinfinally_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
