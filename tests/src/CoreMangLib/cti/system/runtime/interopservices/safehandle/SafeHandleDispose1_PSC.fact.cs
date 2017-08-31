using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_runtime_interopservices_safehandle_SafeHandleDispose1_PSC_SafeHandleDispose1_PSC_
    {
        [OuterLoop]
        [Fact]
        public void _system_runtime_interopservices_safehandle_SafeHandleDispose1_PSC_SafeHandleDispose1_PSC_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\runtime\\interopservices\\safehandle\\SafeHandleDispose1_PSC\\SafeHandleDispose1_PSC.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
