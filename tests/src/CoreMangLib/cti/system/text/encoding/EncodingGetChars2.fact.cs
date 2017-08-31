using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_encoding_EncodingGetChars2_EncodingGetChars2_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_encoding_EncodingGetChars2_EncodingGetChars2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\encoding\\EncodingGetChars2\\EncodingGetChars2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
