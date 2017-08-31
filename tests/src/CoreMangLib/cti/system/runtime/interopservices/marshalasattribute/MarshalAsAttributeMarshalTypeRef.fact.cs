using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_runtime_interopservices_marshalasattribute_MarshalAsAttributeMarshalTypeRef_MarshalAsAttributeMarshalTypeRef_
    {
        [OuterLoop]
        [Fact]
        public void _system_runtime_interopservices_marshalasattribute_MarshalAsAttributeMarshalTypeRef_MarshalAsAttributeMarshalTypeRef_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\runtime\\interopservices\\marshalasattribute\\MarshalAsAttributeMarshalTypeRef\\MarshalAsAttributeMarshalTypeRef.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
