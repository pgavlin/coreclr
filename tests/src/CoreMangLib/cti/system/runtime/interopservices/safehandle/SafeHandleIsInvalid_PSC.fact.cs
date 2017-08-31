using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_runtime_interopservices_safehandle_SafeHandleIsInvalid_PSC_SafeHandleIsInvalid_PSC_
    {
        [OuterLoop]
        [Fact]
        public void _system_runtime_interopservices_safehandle_SafeHandleIsInvalid_PSC_SafeHandleIsInvalid_PSC_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\runtime\\interopservices\\safehandle\\SafeHandleIsInvalid_PSC\\SafeHandleIsInvalid_PSC.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
