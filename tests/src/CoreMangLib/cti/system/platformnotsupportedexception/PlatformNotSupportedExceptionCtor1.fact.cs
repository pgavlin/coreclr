using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_platformnotsupportedexception_PlatformNotSupportedExceptionCtor1_PlatformNotSupportedExceptionCtor1_
    {
        [OuterLoop]
        [Fact]
        public void _system_platformnotsupportedexception_PlatformNotSupportedExceptionCtor1_PlatformNotSupportedExceptionCtor1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\platformnotsupportedexception\\PlatformNotSupportedExceptionCtor1\\PlatformNotSupportedExceptionCtor1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
