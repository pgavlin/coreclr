using CoreclrTestLib;
using Xunit;

namespace Interop_PrimitiveMarshalling
{
    class _UIntPtr_PInvokeUIntPtrTest_PInvokeUIntPtrTest_
    {
        [OuterLoop]
        [Fact]
        public void _UIntPtr_PInvokeUIntPtrTest_PInvokeUIntPtrTest_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Interop\\PrimitiveMarshalling\\UIntPtr\\PInvokeUIntPtrTest\\PInvokeUIntPtrTest.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
