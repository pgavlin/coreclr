using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_runtime_interopservices_gchandletype_GCHandleTypeWeak_GCHandleTypeWeak_
    {
        [OuterLoop]
        [Fact]
        public void _system_runtime_interopservices_gchandletype_GCHandleTypeWeak_GCHandleTypeWeak_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\runtime\\interopservices\\gchandletype\\GCHandleTypeWeak\\GCHandleTypeWeak.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
