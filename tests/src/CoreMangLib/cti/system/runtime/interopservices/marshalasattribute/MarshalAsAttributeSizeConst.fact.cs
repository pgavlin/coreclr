using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_runtime_interopservices_marshalasattribute_MarshalAsAttributeSizeConst_MarshalAsAttributeSizeConst_
    {
        [OuterLoop]
        [Fact]
        public void _system_runtime_interopservices_marshalasattribute_MarshalAsAttributeSizeConst_MarshalAsAttributeSizeConst_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\runtime\\interopservices\\marshalasattribute\\MarshalAsAttributeSizeConst\\MarshalAsAttributeSizeConst.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
