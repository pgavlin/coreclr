using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _IL_PInvokeTail_TailWinApi_TailWinApi_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [Fact]
        public void _IL_PInvokeTail_TailWinApi_TailWinApi_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\IL\\PInvokeTail\\TailWinApi\\TailWinApi.cmd");
        }
    }
}
