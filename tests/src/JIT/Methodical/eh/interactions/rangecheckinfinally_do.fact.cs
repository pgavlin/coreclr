using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_interactions_rangecheckinfinally_do_rangecheckinfinally_do_
    {
        [Fact]
        public void _eh_interactions_rangecheckinfinally_do_rangecheckinfinally_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\interactions\\rangecheckinfinally_do\\rangecheckinfinally_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
