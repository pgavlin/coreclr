using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_platformnotsupportedexception_PlatformNotSupportedExceptionCtor2_PlatformNotSupportedExceptionCtor2_
    {
        [OuterLoop]
        [Fact]
        public void _system_platformnotsupportedexception_PlatformNotSupportedExceptionCtor2_PlatformNotSupportedExceptionCtor2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\platformnotsupportedexception\\PlatformNotSupportedExceptionCtor2\\PlatformNotSupportedExceptionCtor2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
