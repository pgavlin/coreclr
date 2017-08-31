using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_encoding_EncodingGetByteCount_EncodingGetByteCount_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_encoding_EncodingGetByteCount_EncodingGetByteCount_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\encoding\\EncodingGetByteCount\\EncodingGetByteCount.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
