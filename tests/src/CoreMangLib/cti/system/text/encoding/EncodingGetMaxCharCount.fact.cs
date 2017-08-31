using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_encoding_EncodingGetMaxCharCount_EncodingGetMaxCharCount_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_encoding_EncodingGetMaxCharCount_EncodingGetMaxCharCount_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\encoding\\EncodingGetMaxCharCount\\EncodingGetMaxCharCount.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
