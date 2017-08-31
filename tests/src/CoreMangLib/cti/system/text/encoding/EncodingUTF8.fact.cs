using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_encoding_EncodingUTF8_EncodingUTF8_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_encoding_EncodingUTF8_EncodingUTF8_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\encoding\\EncodingUTF8\\EncodingUTF8.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
