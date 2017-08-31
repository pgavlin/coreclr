using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_io_fileshare_FileShareReadWrite_FileShareReadWrite_
    {
        [OuterLoop]
        [Fact]
        public void _system_io_fileshare_FileShareReadWrite_FileShareReadWrite_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\io\\fileshare\\FileShareReadWrite\\FileShareReadWrite.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
