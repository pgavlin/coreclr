using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_interactions_switchinfinally_d_switchinfinally_d_
    {
        [Fact]
        public void _eh_interactions_switchinfinally_d_switchinfinally_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\interactions\\switchinfinally_d\\switchinfinally_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
