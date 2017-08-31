using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_invalidcastexception_InvalidCastExceptionctor1_InvalidCastExceptionctor1_
    {
        [OuterLoop]
        [Fact]
        public void _system_invalidcastexception_InvalidCastExceptionctor1_InvalidCastExceptionctor1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\invalidcastexception\\InvalidCastExceptionctor1\\InvalidCastExceptionctor1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
