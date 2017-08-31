using CoreclrTestLib;
using Xunit;

namespace Interop_FuncPtrAsDelegateParam
{
    class _FuncPtrAsDelegateParam_FuncPtrAsDelegateParam_
    {
        [OuterLoop]
        [Fact]
        public void _FuncPtrAsDelegateParam_FuncPtrAsDelegateParam_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Interop\\FuncPtrAsDelegateParam\\FuncPtrAsDelegateParam\\FuncPtrAsDelegateParam.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
