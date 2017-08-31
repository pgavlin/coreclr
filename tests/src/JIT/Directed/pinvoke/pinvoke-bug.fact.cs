using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _pinvoke_pinvoke_bug_pinvoke_bug_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _pinvoke_pinvoke_bug_pinvoke_bug_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\pinvoke\\pinvoke-bug\\pinvoke-bug.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
