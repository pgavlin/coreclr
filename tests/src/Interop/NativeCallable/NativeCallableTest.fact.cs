using CoreclrTestLib;
using Xunit;

namespace Interop_NativeCallable
{
    class _NativeCallableTest_NativeCallableTest_
    {
        [OuterLoop]
        [Fact]
        public void _NativeCallableTest_NativeCallableTest_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Interop\\NativeCallable\\NativeCallableTest\\NativeCallableTest.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
