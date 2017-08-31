using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_encoder_EncoderCtor_EncoderCtor_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_encoder_EncoderCtor_EncoderCtor_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\encoder\\EncoderCtor\\EncoderCtor.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
