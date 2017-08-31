using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_io_filenotfoundexception_FileNotFoundExceptionCtor2_FileNotFoundExceptionCtor2_
    {
        [OuterLoop]
        [Fact]
        public void _system_io_filenotfoundexception_FileNotFoundExceptionCtor2_FileNotFoundExceptionCtor2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\io\\filenotfoundexception\\FileNotFoundExceptionCtor2\\FileNotFoundExceptionCtor2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
