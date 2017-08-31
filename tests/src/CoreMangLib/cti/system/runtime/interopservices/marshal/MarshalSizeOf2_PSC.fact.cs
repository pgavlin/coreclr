using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_runtime_interopservices_marshal_MarshalSizeOf2_PSC_MarshalSizeOf2_PSC_
    {
        [OuterLoop]
        [Fact]
        public void _system_runtime_interopservices_marshal_MarshalSizeOf2_PSC_MarshalSizeOf2_PSC_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\runtime\\interopservices\\marshal\\MarshalSizeOf2_PSC\\MarshalSizeOf2_PSC.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
