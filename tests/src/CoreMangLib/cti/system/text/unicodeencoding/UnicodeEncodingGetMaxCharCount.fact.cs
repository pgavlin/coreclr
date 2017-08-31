using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_unicodeencoding_UnicodeEncodingGetMaxCharCount_UnicodeEncodingGetMaxCharCount_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_unicodeencoding_UnicodeEncodingGetMaxCharCount_UnicodeEncodingGetMaxCharCount_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\unicodeencoding\\UnicodeEncodingGetMaxCharCount\\UnicodeEncodingGetMaxCharCount.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
