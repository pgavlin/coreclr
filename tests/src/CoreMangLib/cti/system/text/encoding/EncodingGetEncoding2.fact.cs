using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_encoding_EncodingGetEncoding2_EncodingGetEncoding2_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_encoding_EncodingGetEncoding2_EncodingGetEncoding2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\encoding\\EncodingGetEncoding2\\EncodingGetEncoding2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
