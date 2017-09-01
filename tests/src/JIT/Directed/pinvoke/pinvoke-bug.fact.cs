using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _pinvoke_pinvoke_bug_pinvoke_bug_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _pinvoke_pinvoke_bug_pinvoke_bug_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\pinvoke\\pinvoke-bug\\pinvoke-bug.cmd");
        }
    }
}
