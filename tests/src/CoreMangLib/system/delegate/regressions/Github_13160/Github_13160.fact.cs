using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_system
{
    class _delegate_regressions_Github_13160_Github_13160_Github_13160_
    {
        [OuterLoop]
        [Fact]
        public void _delegate_regressions_Github_13160_Github_13160_Github_13160_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\system\\delegate\\regressions\\Github_13160\\Github_13160\\Github_13160.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
