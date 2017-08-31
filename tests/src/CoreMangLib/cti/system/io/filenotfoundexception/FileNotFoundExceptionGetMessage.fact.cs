using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_io_filenotfoundexception_FileNotFoundExceptionGetMessage_FileNotFoundExceptionGetMessage_
    {
        [OuterLoop]
        [Fact]
        public void _system_io_filenotfoundexception_FileNotFoundExceptionGetMessage_FileNotFoundExceptionGetMessage_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\io\\filenotfoundexception\\FileNotFoundExceptionGetMessage\\FileNotFoundExceptionGetMessage.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
