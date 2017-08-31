using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_encoding_EncodingGetCharCount_EncodingGetCharCount_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_encoding_EncodingGetCharCount_EncodingGetCharCount_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\encoding\\EncodingGetCharCount\\EncodingGetCharCount.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
