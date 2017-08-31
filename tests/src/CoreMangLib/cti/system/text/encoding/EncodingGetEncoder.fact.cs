using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_encoding_EncodingGetEncoder_EncodingGetEncoder_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_encoding_EncodingGetEncoder_EncodingGetEncoder_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\encoding\\EncodingGetEncoder\\EncodingGetEncoder.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
