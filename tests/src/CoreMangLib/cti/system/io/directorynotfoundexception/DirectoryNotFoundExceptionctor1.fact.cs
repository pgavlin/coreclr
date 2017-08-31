using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_io_directorynotfoundexception_DirectoryNotFoundExceptionctor1_DirectoryNotFoundExceptionctor1_
    {
        [OuterLoop]
        [Fact]
        public void _system_io_directorynotfoundexception_DirectoryNotFoundExceptionctor1_DirectoryNotFoundExceptionctor1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\io\\directorynotfoundexception\\DirectoryNotFoundExceptionctor1\\DirectoryNotFoundExceptionctor1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
