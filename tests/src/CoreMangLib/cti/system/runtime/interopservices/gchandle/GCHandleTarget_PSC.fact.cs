using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_runtime_interopservices_gchandle_GCHandleTarget_PSC_GCHandleTarget_PSC_
    {
        [OuterLoop]
        [Fact]
        public void _system_runtime_interopservices_gchandle_GCHandleTarget_PSC_GCHandleTarget_PSC_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\runtime\\interopservices\\gchandle\\GCHandleTarget_PSC\\GCHandleTarget_PSC.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
