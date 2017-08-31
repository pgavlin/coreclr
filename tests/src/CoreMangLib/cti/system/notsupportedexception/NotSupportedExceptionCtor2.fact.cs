using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_notsupportedexception_NotSupportedExceptionCtor2_NotSupportedExceptionCtor2_
    {
        [OuterLoop]
        [Fact]
        public void _system_notsupportedexception_NotSupportedExceptionCtor2_NotSupportedExceptionCtor2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\notsupportedexception\\NotSupportedExceptionCtor2\\NotSupportedExceptionCtor2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
