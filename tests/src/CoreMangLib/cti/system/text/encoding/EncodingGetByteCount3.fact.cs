using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_encoding_EncodingGetByteCount3_EncodingGetByteCount3_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_encoding_EncodingGetByteCount3_EncodingGetByteCount3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\encoding\\EncodingGetByteCount3\\EncodingGetByteCount3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
