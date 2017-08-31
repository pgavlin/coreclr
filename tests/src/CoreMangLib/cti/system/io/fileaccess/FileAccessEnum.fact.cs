using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_io_fileaccess_FileAccessEnum_FileAccessEnum_
    {
        [OuterLoop]
        [Fact]
        public void _system_io_fileaccess_FileAccessEnum_FileAccessEnum_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\io\\fileaccess\\FileAccessEnum\\FileAccessEnum.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
