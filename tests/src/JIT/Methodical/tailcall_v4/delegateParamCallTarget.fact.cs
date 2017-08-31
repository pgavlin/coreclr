using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _tailcall_v4_delegateParamCallTarget_delegateParamCallTarget_
    {
        [OuterLoop]
        [Fact]
        public void _tailcall_v4_delegateParamCallTarget_delegateParamCallTarget_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\tailcall_v4\\delegateParamCallTarget\\delegateParamCallTarget.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
