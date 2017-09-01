using CoreclrTestLib;
using Xunit;

namespace Interop_NativeCallable
{
    public class _NativeCallableTest_NativeCallableTest_
    {
        [OuterLoop]
        [Fact]
        public void _NativeCallableTest_NativeCallableTest_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Interop\\NativeCallable\\NativeCallableTest\\NativeCallableTest.cmd");
        }
    }
}
