using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_encoding_EncodingGetBytes4_EncodingGetBytes4_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_encoding_EncodingGetBytes4_EncodingGetBytes4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\encoding\\EncodingGetBytes4\\EncodingGetBytes4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
