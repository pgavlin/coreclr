using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_encoding_EncodingGetCharCount2_EncodingGetCharCount2_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_encoding_EncodingGetCharCount2_EncodingGetCharCount2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\encoding\\EncodingGetCharCount2\\EncodingGetCharCount2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
