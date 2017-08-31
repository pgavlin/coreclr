using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_runtime_interopservices_gchandletype_GCHandleTypeWeakTrackResurrection_GCHandleTypeWeakTrackResurrection_
    {
        [OuterLoop]
        [Fact]
        public void _system_runtime_interopservices_gchandletype_GCHandleTypeWeakTrackResurrection_GCHandleTypeWeakTrackResurrection_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\runtime\\interopservices\\gchandletype\\GCHandleTypeWeakTrackResurrection\\GCHandleTypeWeakTrackResurrection.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
