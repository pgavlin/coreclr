using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_io_stream_StreamWriteTimeOut_PSC_StreamWriteTimeOut_PSC_
    {
        [OuterLoop]
        [Fact]
        public void _system_io_stream_StreamWriteTimeOut_PSC_StreamWriteTimeOut_PSC_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\io\\stream\\StreamWriteTimeOut_PSC\\StreamWriteTimeOut_PSC.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
