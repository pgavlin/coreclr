using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_io_filestream_FileStreamDispose_PSC_FileStreamDispose_PSC_
    {
        [OuterLoop]
        [Fact]
        public void _system_io_filestream_FileStreamDispose_PSC_FileStreamDispose_PSC_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\io\\filestream\\FileStreamDispose_PSC\\FileStreamDispose_PSC.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
