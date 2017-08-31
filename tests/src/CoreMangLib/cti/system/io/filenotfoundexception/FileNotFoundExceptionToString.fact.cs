using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_io_filenotfoundexception_FileNotFoundExceptionToString_FileNotFoundExceptionToString_
    {
        [OuterLoop]
        [Fact]
        public void _system_io_filenotfoundexception_FileNotFoundExceptionToString_FileNotFoundExceptionToString_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\io\\filenotfoundexception\\FileNotFoundExceptionToString\\FileNotFoundExceptionToString.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
