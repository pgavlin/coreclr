using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_badimageformatexception_BadImageFormatExceptionToString_BadImageFormatExceptionToString_
    {
        [OuterLoop]
        [Fact]
        public void _system_badimageformatexception_BadImageFormatExceptionToString_BadImageFormatExceptionToString_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\badimageformatexception\\BadImageFormatExceptionToString\\BadImageFormatExceptionToString.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
