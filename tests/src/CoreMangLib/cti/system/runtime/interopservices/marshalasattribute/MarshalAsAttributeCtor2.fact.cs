using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_runtime_interopservices_marshalasattribute_MarshalAsAttributeCtor2_MarshalAsAttributeCtor2_
    {
        [OuterLoop]
        [Fact]
        public void _system_runtime_interopservices_marshalasattribute_MarshalAsAttributeCtor2_MarshalAsAttributeCtor2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\runtime\\interopservices\\marshalasattribute\\MarshalAsAttributeCtor2\\MarshalAsAttributeCtor2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
