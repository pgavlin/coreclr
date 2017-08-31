using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_string_StringCompareOrdinal1_StringCompareOrdinal1_
    {
        [OuterLoop]
        [Fact]
        public void _system_string_StringCompareOrdinal1_StringCompareOrdinal1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\string\\StringCompareOrdinal1\\StringCompareOrdinal1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
