using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_runtime_interopservices_gchandletype_GCHandleTypePinned_GCHandleTypePinned_
    {
        [OuterLoop]
        [Fact]
        public void _system_runtime_interopservices_gchandletype_GCHandleTypePinned_GCHandleTypePinned_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\runtime\\interopservices\\gchandletype\\GCHandleTypePinned\\GCHandleTypePinned.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
