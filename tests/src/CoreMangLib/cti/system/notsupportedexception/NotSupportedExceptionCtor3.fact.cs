using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_notsupportedexception_NotSupportedExceptionCtor3_NotSupportedExceptionCtor3_
    {
        [OuterLoop]
        [Fact]
        public void _system_notsupportedexception_NotSupportedExceptionCtor3_NotSupportedExceptionCtor3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\notsupportedexception\\NotSupportedExceptionCtor3\\NotSupportedExceptionCtor3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
