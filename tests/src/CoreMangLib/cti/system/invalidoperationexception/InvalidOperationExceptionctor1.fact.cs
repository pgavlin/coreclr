using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_invalidoperationexception_InvalidOperationExceptionctor1_InvalidOperationExceptionctor1_
    {
        [OuterLoop]
        [Fact]
        public void _system_invalidoperationexception_InvalidOperationExceptionctor1_InvalidOperationExceptionctor1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\invalidoperationexception\\InvalidOperationExceptionctor1\\InvalidOperationExceptionctor1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
