using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_runtime_interopservices_safehandle_SafeHandleIsClosed_PSC_SafeHandleIsClosed_PSC_
    {
        [OuterLoop]
        [Fact]
        public void _system_runtime_interopservices_safehandle_SafeHandleIsClosed_PSC_SafeHandleIsClosed_PSC_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\runtime\\interopservices\\safehandle\\SafeHandleIsClosed_PSC\\SafeHandleIsClosed_PSC.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
