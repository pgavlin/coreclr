using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_runtime_interopservices_gchandle_GCHandleFree_PSC_GCHandleFree_PSC_
    {
        [OuterLoop]
        [Fact]
        public void _system_runtime_interopservices_gchandle_GCHandleFree_PSC_GCHandleFree_PSC_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\runtime\\interopservices\\gchandle\\GCHandleFree_PSC\\GCHandleFree_PSC.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
