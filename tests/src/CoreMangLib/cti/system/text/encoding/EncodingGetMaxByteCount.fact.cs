using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_encoding_EncodingGetMaxByteCount_EncodingGetMaxByteCount_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_encoding_EncodingGetMaxByteCount_EncodingGetMaxByteCount_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\encoding\\EncodingGetMaxByteCount\\EncodingGetMaxByteCount.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
