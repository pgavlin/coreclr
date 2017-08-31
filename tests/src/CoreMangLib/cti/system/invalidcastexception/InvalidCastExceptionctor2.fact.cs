using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_invalidcastexception_InvalidCastExceptionctor2_InvalidCastExceptionctor2_
    {
        [OuterLoop]
        [Fact]
        public void _system_invalidcastexception_InvalidCastExceptionctor2_InvalidCastExceptionctor2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\invalidcastexception\\InvalidCastExceptionctor2\\InvalidCastExceptionctor2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
