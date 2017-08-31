using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_encoding_EncodingGetChars3_EncodingGetChars3_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_encoding_EncodingGetChars3_EncodingGetChars3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\encoding\\EncodingGetChars3\\EncodingGetChars3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
