using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_invalidcastexception_InvalidCastExceptionctor3_InvalidCastExceptionctor3_
    {
        [OuterLoop]
        [Fact]
        public void _system_invalidcastexception_InvalidCastExceptionctor3_InvalidCastExceptionctor3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\invalidcastexception\\InvalidCastExceptionctor3\\InvalidCastExceptionctor3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
