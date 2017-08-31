using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_invalidoperationexception_InvalidOperationExceptionctor2_InvalidOperationExceptionctor2_
    {
        [OuterLoop]
        [Fact]
        public void _system_invalidoperationexception_InvalidOperationExceptionctor2_InvalidOperationExceptionctor2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\invalidoperationexception\\InvalidOperationExceptionctor2\\InvalidOperationExceptionctor2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
