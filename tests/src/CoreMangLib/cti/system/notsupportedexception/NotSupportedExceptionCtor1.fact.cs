using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_notsupportedexception_NotSupportedExceptionCtor1_NotSupportedExceptionCtor1_
    {
        [OuterLoop]
        [Fact]
        public void _system_notsupportedexception_NotSupportedExceptionCtor1_NotSupportedExceptionCtor1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\notsupportedexception\\NotSupportedExceptionCtor1\\NotSupportedExceptionCtor1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
