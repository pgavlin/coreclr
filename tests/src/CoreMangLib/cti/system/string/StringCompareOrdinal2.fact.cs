using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_string_StringCompareOrdinal2_StringCompareOrdinal2_
    {
        [OuterLoop]
        [Fact]
        public void _system_string_StringCompareOrdinal2_StringCompareOrdinal2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\string\\StringCompareOrdinal2\\StringCompareOrdinal2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
