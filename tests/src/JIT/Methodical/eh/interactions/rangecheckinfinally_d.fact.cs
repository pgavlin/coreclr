using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_interactions_rangecheckinfinally_d_rangecheckinfinally_d_
    {
        [Fact]
        public void _eh_interactions_rangecheckinfinally_d_rangecheckinfinally_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\interactions\\rangecheckinfinally_d\\rangecheckinfinally_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
