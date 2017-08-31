using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_io_fileaccess_FileAccessRead_FileAccessRead_
    {
        [OuterLoop]
        [Fact]
        public void _system_io_fileaccess_FileAccessRead_FileAccessRead_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\io\\fileaccess\\FileAccessRead\\FileAccessRead.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
