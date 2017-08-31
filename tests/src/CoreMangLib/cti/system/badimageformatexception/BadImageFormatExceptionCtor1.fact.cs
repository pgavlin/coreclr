using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_badimageformatexception_BadImageFormatExceptionCtor1_BadImageFormatExceptionCtor1_
    {
        [OuterLoop]
        [Fact]
        public void _system_badimageformatexception_BadImageFormatExceptionCtor1_BadImageFormatExceptionCtor1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\badimageformatexception\\BadImageFormatExceptionCtor1\\BadImageFormatExceptionCtor1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
