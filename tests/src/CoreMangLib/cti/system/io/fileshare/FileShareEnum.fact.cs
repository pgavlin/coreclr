using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_io_fileshare_FileShareEnum_FileShareEnum_
    {
        [OuterLoop]
        [Fact]
        public void _system_io_fileshare_FileShareEnum_FileShareEnum_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\io\\fileshare\\FileShareEnum\\FileShareEnum.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
