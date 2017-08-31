using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_runtime_interopservices_marshalasattribute_MarshalAsAttributeMarshalCookie_MarshalAsAttributeMarshalCookie_
    {
        [OuterLoop]
        [Fact]
        public void _system_runtime_interopservices_marshalasattribute_MarshalAsAttributeMarshalCookie_MarshalAsAttributeMarshalCookie_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\runtime\\interopservices\\marshalasattribute\\MarshalAsAttributeMarshalCookie\\MarshalAsAttributeMarshalCookie.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
