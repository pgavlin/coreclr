using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_runtime_interopservices_marshalasattribute_MarshalAsAttributeSizeParamIndex_MarshalAsAttributeSizeParamIndex_
    {
        [OuterLoop]
        [Fact]
        public void _system_runtime_interopservices_marshalasattribute_MarshalAsAttributeSizeParamIndex_MarshalAsAttributeSizeParamIndex_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\runtime\\interopservices\\marshalasattribute\\MarshalAsAttributeSizeParamIndex\\MarshalAsAttributeSizeParamIndex.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
