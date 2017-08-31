using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_interactions_rangecheckinfinally_r_rangecheckinfinally_r_
    {
        [Fact]
        public void _eh_interactions_rangecheckinfinally_r_rangecheckinfinally_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\interactions\\rangecheckinfinally_r\\rangecheckinfinally_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
