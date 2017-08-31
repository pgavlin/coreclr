using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_io_fileaccess_FileAccessWrite_FileAccessWrite_
    {
        [OuterLoop]
        [Fact]
        public void _system_io_fileaccess_FileAccessWrite_FileAccessWrite_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\io\\fileaccess\\FileAccessWrite\\FileAccessWrite.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
