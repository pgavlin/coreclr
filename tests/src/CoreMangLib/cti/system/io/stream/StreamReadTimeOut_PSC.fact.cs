using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_io_stream_StreamReadTimeOut_PSC_StreamReadTimeOut_PSC_
    {
        [OuterLoop]
        [Fact]
        public void _system_io_stream_StreamReadTimeOut_PSC_StreamReadTimeOut_PSC_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\io\\stream\\StreamReadTimeOut_PSC\\StreamReadTimeOut_PSC.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
