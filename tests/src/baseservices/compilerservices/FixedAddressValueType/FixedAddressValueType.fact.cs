using CoreclrTestLib;
using Xunit;

namespace baseservices_compilerservices
{
    class _FixedAddressValueType_FixedAddressValueType_FixedAddressValueType_
    {
        [OuterLoop]
        [Fact]
        public void _FixedAddressValueType_FixedAddressValueType_FixedAddressValueType_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\compilerservices\\FixedAddressValueType\\FixedAddressValueType\\FixedAddressValueType.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
