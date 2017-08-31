using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_io_stream_StreamDispose2_PSC_StreamDispose2_PSC_
    {
        [OuterLoop]
        [Fact]
        public void _system_io_stream_StreamDispose2_PSC_StreamDispose2_PSC_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\io\\stream\\StreamDispose2_PSC\\StreamDispose2_PSC.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
