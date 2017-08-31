using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_io_filenotfoundexception_FileNotFoundExceptionMessage_FileNotFoundExceptionMessage_
    {
        [OuterLoop]
        [Fact]
        public void _system_io_filenotfoundexception_FileNotFoundExceptionMessage_FileNotFoundExceptionMessage_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\io\\filenotfoundexception\\FileNotFoundExceptionMessage\\FileNotFoundExceptionMessage.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
