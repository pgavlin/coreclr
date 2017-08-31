using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_invalidoperationexception_InvalidOperationExceptionctor3_InvalidOperationExceptionctor3_
    {
        [OuterLoop]
        [Fact]
        public void _system_invalidoperationexception_InvalidOperationExceptionctor3_InvalidOperationExceptionctor3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\invalidoperationexception\\InvalidOperationExceptionctor3\\InvalidOperationExceptionctor3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
