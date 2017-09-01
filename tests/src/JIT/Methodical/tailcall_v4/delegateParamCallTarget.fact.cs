using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _tailcall_v4_delegateParamCallTarget_delegateParamCallTarget_
    {
        [OuterLoop]
        [Fact]
        public void _tailcall_v4_delegateParamCallTarget_delegateParamCallTarget_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\tailcall_v4\\delegateParamCallTarget\\delegateParamCallTarget.cmd");
        }
    }
}
