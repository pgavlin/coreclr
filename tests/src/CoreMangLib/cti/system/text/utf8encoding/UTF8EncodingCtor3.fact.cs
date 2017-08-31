using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_utf8encoding_UTF8EncodingCtor3_UTF8EncodingCtor3_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_utf8encoding_UTF8EncodingCtor3_UTF8EncodingCtor3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\utf8encoding\\UTF8EncodingCtor3\\UTF8EncodingCtor3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
