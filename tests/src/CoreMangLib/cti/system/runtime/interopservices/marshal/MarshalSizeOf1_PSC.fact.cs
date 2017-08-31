using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_runtime_interopservices_marshal_MarshalSizeOf1_PSC_MarshalSizeOf1_PSC_
    {
        [OuterLoop]
        [Fact]
        public void _system_runtime_interopservices_marshal_MarshalSizeOf1_PSC_MarshalSizeOf1_PSC_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\runtime\\interopservices\\marshal\\MarshalSizeOf1_PSC\\MarshalSizeOf1_PSC.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
