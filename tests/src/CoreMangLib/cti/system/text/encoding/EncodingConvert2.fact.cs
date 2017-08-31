using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_encoding_EncodingConvert2_EncodingConvert2_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_encoding_EncodingConvert2_EncodingConvert2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\encoding\\EncodingConvert2\\EncodingConvert2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
