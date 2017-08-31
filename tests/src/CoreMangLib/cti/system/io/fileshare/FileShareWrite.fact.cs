using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_io_fileshare_FileShareWrite_FileShareWrite_
    {
        [OuterLoop]
        [Fact]
        public void _system_io_fileshare_FileShareWrite_FileShareWrite_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\io\\fileshare\\FileShareWrite\\FileShareWrite.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
