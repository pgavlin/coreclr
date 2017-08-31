using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_encoding_EncodingGetBytes2_EncodingGetBytes2_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_encoding_EncodingGetBytes2_EncodingGetBytes2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\encoding\\EncodingGetBytes2\\EncodingGetBytes2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
