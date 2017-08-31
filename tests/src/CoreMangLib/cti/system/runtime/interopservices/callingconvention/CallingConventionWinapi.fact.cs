using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_runtime_interopservices_callingconvention_CallingConventionWinapi_CallingConventionWinapi_
    {
        [OuterLoop]
        [Fact]
        public void _system_runtime_interopservices_callingconvention_CallingConventionWinapi_CallingConventionWinapi_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\runtime\\interopservices\\callingconvention\\CallingConventionWinapi\\CallingConventionWinapi.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
