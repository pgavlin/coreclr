using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_platformnotsupportedexception_PlatformNotSupportedExceptionCtor3_PlatformNotSupportedExceptionCtor3_
    {
        [OuterLoop]
        [Fact]
        public void _system_platformnotsupportedexception_PlatformNotSupportedExceptionCtor3_PlatformNotSupportedExceptionCtor3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\platformnotsupportedexception\\PlatformNotSupportedExceptionCtor3\\PlatformNotSupportedExceptionCtor3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
