using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_encoding_EncodingGetPreamble_EncodingGetPreamble_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_encoding_EncodingGetPreamble_EncodingGetPreamble_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\encoding\\EncodingGetPreamble\\EncodingGetPreamble.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
