using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_encoding_EncodingBigEndianUnicode_EncodingBigEndianUnicode_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_encoding_EncodingBigEndianUnicode_EncodingBigEndianUnicode_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\encoding\\EncodingBigEndianUnicode\\EncodingBigEndianUnicode.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
