using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_io_filenotfoundexception_FileNotFoundExceptionCtor_FileNotFoundExceptionCtor_
    {
        [OuterLoop]
        [Fact]
        public void _system_io_filenotfoundexception_FileNotFoundExceptionCtor_FileNotFoundExceptionCtor_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\io\\filenotfoundexception\\FileNotFoundExceptionCtor\\FileNotFoundExceptionCtor.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
