using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_interactions_rangecheckinfinally_ro_rangecheckinfinally_ro_
    {
        [Fact]
        public void _eh_interactions_rangecheckinfinally_ro_rangecheckinfinally_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\interactions\\rangecheckinfinally_ro\\rangecheckinfinally_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
