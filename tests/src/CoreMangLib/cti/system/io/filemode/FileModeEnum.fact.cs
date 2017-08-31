using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_io_filemode_FileModeEnum_FileModeEnum_
    {
        [OuterLoop]
        [Fact]
        public void _system_io_filemode_FileModeEnum_FileModeEnum_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\io\\filemode\\FileModeEnum\\FileModeEnum.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
