using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_runtime_interopservices_gchandletype_GCHandleTypeNormal_GCHandleTypeNormal_
    {
        [OuterLoop]
        [Fact]
        public void _system_runtime_interopservices_gchandletype_GCHandleTypeNormal_GCHandleTypeNormal_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\runtime\\interopservices\\gchandletype\\GCHandleTypeNormal\\GCHandleTypeNormal.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
