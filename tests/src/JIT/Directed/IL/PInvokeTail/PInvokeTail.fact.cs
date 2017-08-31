using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _IL_PInvokeTail_PInvokeTail_PInvokeTail_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _IL_PInvokeTail_PInvokeTail_PInvokeTail_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\IL\\PInvokeTail\\PInvokeTail\\PInvokeTail.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
