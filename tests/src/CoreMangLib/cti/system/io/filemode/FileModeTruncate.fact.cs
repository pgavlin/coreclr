using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_io_filemode_FileModeTruncate_FileModeTruncate_
    {
        [OuterLoop]
        [Fact]
        public void _system_io_filemode_FileModeTruncate_FileModeTruncate_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\io\\filemode\\FileModeTruncate\\FileModeTruncate.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
