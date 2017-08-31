using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _IL_PInvokeTail_TailWinApi_TailWinApi_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [Fact]
        public void _IL_PInvokeTail_TailWinApi_TailWinApi_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\IL\\PInvokeTail\\TailWinApi\\TailWinApi.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
