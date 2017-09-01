using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _coverage_oldtests_callipinvoke_callipinvoke_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [Fact]
        public void _coverage_oldtests_callipinvoke_callipinvoke_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\oldtests\\callipinvoke\\callipinvoke.cmd");
        }
    }
}
