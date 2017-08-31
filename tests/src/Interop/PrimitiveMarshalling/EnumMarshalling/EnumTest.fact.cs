using CoreclrTestLib;
using Xunit;

namespace Interop_PrimitiveMarshalling
{
    class _EnumMarshalling_EnumTest_EnumTest_
    {
        [OuterLoop]
        [Fact]
        public void _EnumMarshalling_EnumTest_EnumTest_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Interop\\PrimitiveMarshalling\\EnumMarshalling\\EnumTest\\EnumTest.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
