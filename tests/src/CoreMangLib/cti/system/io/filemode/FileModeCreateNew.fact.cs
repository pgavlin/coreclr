using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_io_filemode_FileModeCreateNew_FileModeCreateNew_
    {
        [OuterLoop]
        [Fact]
        public void _system_io_filemode_FileModeCreateNew_FileModeCreateNew_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\io\\filemode\\FileModeCreateNew\\FileModeCreateNew.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
