using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_badimageformatexception_BadImageFormatExceptionCtor2_BadImageFormatExceptionCtor2_
    {
        [OuterLoop]
        [Fact]
        public void _system_badimageformatexception_BadImageFormatExceptionCtor2_BadImageFormatExceptionCtor2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\badimageformatexception\\BadImageFormatExceptionCtor2\\BadImageFormatExceptionCtor2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
