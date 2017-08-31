using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_badimageformatexception_BadImageFormatExceptionMessage_BadImageFormatExceptionMessage_
    {
        [OuterLoop]
        [Fact]
        public void _system_badimageformatexception_BadImageFormatExceptionMessage_BadImageFormatExceptionMessage_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\badimageformatexception\\BadImageFormatExceptionMessage\\BadImageFormatExceptionMessage.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
