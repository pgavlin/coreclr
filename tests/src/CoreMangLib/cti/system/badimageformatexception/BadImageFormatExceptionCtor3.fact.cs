using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_badimageformatexception_BadImageFormatExceptionCtor3_BadImageFormatExceptionCtor3_
    {
        [OuterLoop]
        [Fact]
        public void _system_badimageformatexception_BadImageFormatExceptionCtor3_BadImageFormatExceptionCtor3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\badimageformatexception\\BadImageFormatExceptionCtor3\\BadImageFormatExceptionCtor3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
