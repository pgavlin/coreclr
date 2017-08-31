using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_interactions_switchinfinally_r_switchinfinally_r_
    {
        [Fact]
        public void _eh_interactions_switchinfinally_r_switchinfinally_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\interactions\\switchinfinally_r\\switchinfinally_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
