using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_io_stream_StreamDispose1_PSC_StreamDispose1_PSC_
    {
        [OuterLoop]
        [Fact]
        public void _system_io_stream_StreamDispose1_PSC_StreamDispose1_PSC_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\io\\stream\\StreamDispose1_PSC\\StreamDispose1_PSC.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
