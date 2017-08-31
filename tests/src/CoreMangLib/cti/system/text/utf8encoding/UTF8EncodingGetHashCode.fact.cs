using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_utf8encoding_UTF8EncodingGetHashCode_UTF8EncodingGetHashCode_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_utf8encoding_UTF8EncodingGetHashCode_UTF8EncodingGetHashCode_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\utf8encoding\\UTF8EncodingGetHashCode\\UTF8EncodingGetHashCode.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
