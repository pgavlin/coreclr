using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_io_fileshare_FileShareNone_FileShareNone_
    {
        [OuterLoop]
        [Fact]
        public void _system_io_fileshare_FileShareNone_FileShareNone_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\io\\fileshare\\FileShareNone\\FileShareNone.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
