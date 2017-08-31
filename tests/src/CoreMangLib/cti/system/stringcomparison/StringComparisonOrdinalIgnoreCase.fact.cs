using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_stringcomparison_StringComparisonOrdinalIgnoreCase_StringComparisonOrdinalIgnoreCase_
    {
        [OuterLoop]
        [Fact]
        public void _system_stringcomparison_StringComparisonOrdinalIgnoreCase_StringComparisonOrdinalIgnoreCase_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\stringcomparison\\StringComparisonOrdinalIgnoreCase\\StringComparisonOrdinalIgnoreCase.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
