using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_utf8encoding_UTF8EncodingGetString_UTF8EncodingGetString_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_utf8encoding_UTF8EncodingGetString_UTF8EncodingGetString_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\utf8encoding\\UTF8EncodingGetString\\UTF8EncodingGetString.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
