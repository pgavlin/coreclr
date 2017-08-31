using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_encoding_EncodingConvert1_EncodingConvert1_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_encoding_EncodingConvert1_EncodingConvert1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\encoding\\EncodingConvert1\\EncodingConvert1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
