using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_io_stream_StreamNull_PSC_StreamNull_PSC_
    {
        [OuterLoop]
        [Fact]
        public void _system_io_stream_StreamNull_PSC_StreamNull_PSC_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\io\\stream\\StreamNull_PSC\\StreamNull_PSC.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
