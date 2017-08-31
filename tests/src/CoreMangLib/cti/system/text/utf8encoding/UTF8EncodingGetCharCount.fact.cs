using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_utf8encoding_UTF8EncodingGetCharCount_UTF8EncodingGetCharCount_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_utf8encoding_UTF8EncodingGetCharCount_UTF8EncodingGetCharCount_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\utf8encoding\\UTF8EncodingGetCharCount\\UTF8EncodingGetCharCount.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
