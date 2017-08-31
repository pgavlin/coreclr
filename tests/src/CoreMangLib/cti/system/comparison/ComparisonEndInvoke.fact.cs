using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_comparison_ComparisonEndInvoke_ComparisonEndInvoke_
    {
        [OuterLoop]
        [Fact]
        public void _system_comparison_ComparisonEndInvoke_ComparisonEndInvoke_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\comparison\\ComparisonEndInvoke\\ComparisonEndInvoke.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
