using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_decoder_DecoderCtor_DecoderCtor_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_decoder_DecoderCtor_DecoderCtor_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\decoder\\DecoderCtor\\DecoderCtor.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
