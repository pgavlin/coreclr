using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_interactions_switchinfinally_ro_switchinfinally_ro_
    {
        [Fact]
        public void _eh_interactions_switchinfinally_ro_switchinfinally_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\interactions\\switchinfinally_ro\\switchinfinally_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
