using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_io_fileaccess_FileAccessReadWrite_FileAccessReadWrite_
    {
        [OuterLoop]
        [Fact]
        public void _system_io_fileaccess_FileAccessReadWrite_FileAccessReadWrite_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\io\\fileaccess\\FileAccessReadWrite\\FileAccessReadWrite.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
