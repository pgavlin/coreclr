using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_io_fileshare_FileShareRead_FileShareRead_
    {
        [OuterLoop]
        [Fact]
        public void _system_io_fileshare_FileShareRead_FileShareRead_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\io\\fileshare\\FileShareRead\\FileShareRead.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
