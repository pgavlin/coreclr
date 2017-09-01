using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _IL_PInvokeTail_PInvokeTail_PInvokeTail_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _IL_PInvokeTail_PInvokeTail_PInvokeTail_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\IL\\PInvokeTail\\PInvokeTail\\PInvokeTail.cmd");
        }
    }
}
