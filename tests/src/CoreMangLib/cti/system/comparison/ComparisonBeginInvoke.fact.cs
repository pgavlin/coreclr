using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_comparison_ComparisonBeginInvoke_ComparisonBeginInvoke_
    {
        [OuterLoop]
        [Fact]
        public void _system_comparison_ComparisonBeginInvoke_ComparisonBeginInvoke_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\comparison\\ComparisonBeginInvoke\\ComparisonBeginInvoke.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
