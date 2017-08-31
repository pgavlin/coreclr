using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_unicodeencoding_UnicodeEncodingGetMaxByteCount_UnicodeEncodingGetMaxByteCount_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_unicodeencoding_UnicodeEncodingGetMaxByteCount_UnicodeEncodingGetMaxByteCount_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\unicodeencoding\\UnicodeEncodingGetMaxByteCount\\UnicodeEncodingGetMaxByteCount.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
