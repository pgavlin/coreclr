using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_stringcomparison_StringComparisonOrdinal_StringComparisonOrdinal_
    {
        [OuterLoop]
        [Fact]
        public void _system_stringcomparison_StringComparisonOrdinal_StringComparisonOrdinal_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\stringcomparison\\StringComparisonOrdinal\\StringComparisonOrdinal.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
