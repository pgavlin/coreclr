using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_encoding_EncodingGetByteCount1_EncodingGetByteCount1_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_encoding_EncodingGetByteCount1_EncodingGetByteCount1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\encoding\\EncodingGetByteCount1\\EncodingGetByteCount1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
