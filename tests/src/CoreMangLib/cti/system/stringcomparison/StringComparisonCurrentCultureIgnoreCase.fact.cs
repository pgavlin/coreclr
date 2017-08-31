using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_stringcomparison_StringComparisonCurrentCultureIgnoreCase_StringComparisonCurrentCultureIgnoreCase_
    {
        [OuterLoop]
        [Fact]
        public void _system_stringcomparison_StringComparisonCurrentCultureIgnoreCase_StringComparisonCurrentCultureIgnoreCase_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\stringcomparison\\StringComparisonCurrentCultureIgnoreCase\\StringComparisonCurrentCultureIgnoreCase.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
