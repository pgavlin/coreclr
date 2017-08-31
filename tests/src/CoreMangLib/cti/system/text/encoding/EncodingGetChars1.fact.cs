using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_encoding_EncodingGetChars1_EncodingGetChars1_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_encoding_EncodingGetChars1_EncodingGetChars1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\encoding\\EncodingGetChars1\\EncodingGetChars1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
