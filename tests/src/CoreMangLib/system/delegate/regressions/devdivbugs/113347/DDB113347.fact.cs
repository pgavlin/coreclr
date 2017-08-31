using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_system
{
    class _delegate_regressions_devdivbugs_113347_DDB113347_DDB113347_
    {
        [OuterLoop]
        [Fact]
        public void _delegate_regressions_devdivbugs_113347_DDB113347_DDB113347_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\system\\delegate\\regressions\\devdivbugs\\113347\\DDB113347\\DDB113347.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
