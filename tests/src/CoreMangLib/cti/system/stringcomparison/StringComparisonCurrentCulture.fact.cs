using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_stringcomparison_StringComparisonCurrentCulture_StringComparisonCurrentCulture_
    {
        [OuterLoop]
        [Fact]
        public void _system_stringcomparison_StringComparisonCurrentCulture_StringComparisonCurrentCulture_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\stringcomparison\\StringComparisonCurrentCulture\\StringComparisonCurrentCulture.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
