using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_encoding_EncodingUnicode_EncodingUnicode_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_encoding_EncodingUnicode_EncodingUnicode_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\encoding\\EncodingUnicode\\EncodingUnicode.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
