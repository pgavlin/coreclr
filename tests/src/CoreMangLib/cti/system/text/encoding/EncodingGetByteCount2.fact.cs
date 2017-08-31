using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_encoding_EncodingGetByteCount2_EncodingGetByteCount2_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_encoding_EncodingGetByteCount2_EncodingGetByteCount2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\encoding\\EncodingGetByteCount2\\EncodingGetByteCount2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
