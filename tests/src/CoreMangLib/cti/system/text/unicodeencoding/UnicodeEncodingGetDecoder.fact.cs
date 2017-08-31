using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_unicodeencoding_UnicodeEncodingGetDecoder_UnicodeEncodingGetDecoder_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_unicodeencoding_UnicodeEncodingGetDecoder_UnicodeEncodingGetDecoder_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\unicodeencoding\\UnicodeEncodingGetDecoder\\UnicodeEncodingGetDecoder.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
