using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_encoding_EncodingWebName_EncodingWebName_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_encoding_EncodingWebName_EncodingWebName_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\encoding\\EncodingWebName\\EncodingWebName.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
