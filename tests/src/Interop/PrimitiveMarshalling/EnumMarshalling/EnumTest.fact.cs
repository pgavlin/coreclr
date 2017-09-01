using CoreclrTestLib;
using Xunit;

namespace Interop_PrimitiveMarshalling
{
    public class _EnumMarshalling_EnumTest_EnumTest_
    {
        [OuterLoop]
        [Fact]
        public void _EnumMarshalling_EnumTest_EnumTest_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Interop\\PrimitiveMarshalling\\EnumMarshalling\\EnumTest\\EnumTest.cmd");
        }
    }
}
