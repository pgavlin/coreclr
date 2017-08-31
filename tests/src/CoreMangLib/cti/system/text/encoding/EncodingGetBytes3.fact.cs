using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_encoding_EncodingGetBytes3_EncodingGetBytes3_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_encoding_EncodingGetBytes3_EncodingGetBytes3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\encoding\\EncodingGetBytes3\\EncodingGetBytes3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
