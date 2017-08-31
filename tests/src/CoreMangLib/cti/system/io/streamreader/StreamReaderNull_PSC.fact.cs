using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_io_streamreader_StreamReaderNull_PSC_StreamReaderNull_PSC_
    {
        [OuterLoop]
        [Fact]
        public void _system_io_streamreader_StreamReaderNull_PSC_StreamReaderNull_PSC_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\io\\streamreader\\StreamReaderNull_PSC\\StreamReaderNull_PSC.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
