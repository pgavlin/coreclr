using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_io_filemode_FileModeOpen_FileModeOpen_
    {
        [OuterLoop]
        [Fact]
        public void _system_io_filemode_FileModeOpen_FileModeOpen_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\io\\filemode\\FileModeOpen\\FileModeOpen.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
