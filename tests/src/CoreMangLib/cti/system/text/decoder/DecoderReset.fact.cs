using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_decoder_DecoderReset_DecoderReset_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_decoder_DecoderReset_DecoderReset_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\decoder\\DecoderReset\\DecoderReset.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
