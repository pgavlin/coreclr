using CoreclrTestLib;
using Xunit;

namespace Interop_FuncPtrAsDelegateParam
{
    public class _FuncPtrAsDelegateParam_FuncPtrAsDelegateParam_
    {
        [OuterLoop]
        [Fact]
        public void _FuncPtrAsDelegateParam_FuncPtrAsDelegateParam_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Interop\\FuncPtrAsDelegateParam\\FuncPtrAsDelegateParam\\FuncPtrAsDelegateParam.cmd");
        }
    }
}
