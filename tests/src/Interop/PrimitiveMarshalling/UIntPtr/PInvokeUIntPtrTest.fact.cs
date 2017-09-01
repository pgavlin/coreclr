using CoreclrTestLib;
using Xunit;

namespace Interop_PrimitiveMarshalling
{
    public class _UIntPtr_PInvokeUIntPtrTest_PInvokeUIntPtrTest_
    {
        [OuterLoop]
        [Fact]
        public void _UIntPtr_PInvokeUIntPtrTest_PInvokeUIntPtrTest_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Interop\\PrimitiveMarshalling\\UIntPtr\\PInvokeUIntPtrTest\\PInvokeUIntPtrTest.cmd");
        }
    }
}
