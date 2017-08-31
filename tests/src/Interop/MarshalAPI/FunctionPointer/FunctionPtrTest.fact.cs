using CoreclrTestLib;
using Xunit;

namespace Interop_MarshalAPI
{
    class _FunctionPointer_FunctionPtrTest_FunctionPtrTest_
    {
        [Fact]
        public void _FunctionPointer_FunctionPtrTest_FunctionPtrTest_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Interop\\MarshalAPI\\FunctionPointer\\FunctionPtrTest\\FunctionPtrTest.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
