using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_utf8encoding_UTF8EncodingGetMaxCharCount_UTF8EncodingGetMaxCharCount_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_utf8encoding_UTF8EncodingGetMaxCharCount_UTF8EncodingGetMaxCharCount_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\utf8encoding\\UTF8EncodingGetMaxCharCount\\UTF8EncodingGetMaxCharCount.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
