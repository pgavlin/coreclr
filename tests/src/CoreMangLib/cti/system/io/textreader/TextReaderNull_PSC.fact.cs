using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_io_textreader_TextReaderNull_PSC_TextReaderNull_PSC_
    {
        [OuterLoop]
        [Fact]
        public void _system_io_textreader_TextReaderNull_PSC_TextReaderNull_PSC_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\io\\textreader\\TextReaderNull_PSC\\TextReaderNull_PSC.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
