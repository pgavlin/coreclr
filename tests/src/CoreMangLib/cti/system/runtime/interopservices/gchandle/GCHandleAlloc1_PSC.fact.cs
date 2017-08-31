using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_runtime_interopservices_gchandle_GCHandleAlloc1_PSC_GCHandleAlloc1_PSC_
    {
        [OuterLoop]
        [Fact]
        public void _system_runtime_interopservices_gchandle_GCHandleAlloc1_PSC_GCHandleAlloc1_PSC_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\runtime\\interopservices\\gchandle\\GCHandleAlloc1_PSC\\GCHandleAlloc1_PSC.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
