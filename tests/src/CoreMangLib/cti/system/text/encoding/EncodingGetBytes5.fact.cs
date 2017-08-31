using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_encoding_EncodingGetBytes5_EncodingGetBytes5_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_encoding_EncodingGetBytes5_EncodingGetBytes5_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\encoding\\EncodingGetBytes5\\EncodingGetBytes5.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
