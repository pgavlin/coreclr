using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_encoding_EncodingGetCharCount1_EncodingGetCharCount1_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_encoding_EncodingGetCharCount1_EncodingGetCharCount1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\encoding\\EncodingGetCharCount1\\EncodingGetCharCount1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
