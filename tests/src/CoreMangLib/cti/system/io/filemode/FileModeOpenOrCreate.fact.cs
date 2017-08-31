using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_io_filemode_FileModeOpenOrCreate_FileModeOpenOrCreate_
    {
        [OuterLoop]
        [Fact]
        public void _system_io_filemode_FileModeOpenOrCreate_FileModeOpenOrCreate_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\io\\filemode\\FileModeOpenOrCreate\\FileModeOpenOrCreate.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
