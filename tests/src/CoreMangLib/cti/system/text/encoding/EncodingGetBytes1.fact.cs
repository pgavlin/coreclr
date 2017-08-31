using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_encoding_EncodingGetBytes1_EncodingGetBytes1_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_encoding_EncodingGetBytes1_EncodingGetBytes1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\encoding\\EncodingGetBytes1\\EncodingGetBytes1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
