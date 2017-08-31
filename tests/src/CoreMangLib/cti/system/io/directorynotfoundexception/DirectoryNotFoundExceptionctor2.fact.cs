using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_io_directorynotfoundexception_DirectoryNotFoundExceptionctor2_DirectoryNotFoundExceptionctor2_
    {
        [OuterLoop]
        [Fact]
        public void _system_io_directorynotfoundexception_DirectoryNotFoundExceptionctor2_DirectoryNotFoundExceptionctor2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\io\\directorynotfoundexception\\DirectoryNotFoundExceptionctor2\\DirectoryNotFoundExceptionctor2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
