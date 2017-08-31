using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_comparison_ComparisonInvoke_ComparisonInvoke_
    {
        [OuterLoop]
        [Fact]
        public void _system_comparison_ComparisonInvoke_ComparisonInvoke_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\comparison\\ComparisonInvoke\\ComparisonInvoke.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
