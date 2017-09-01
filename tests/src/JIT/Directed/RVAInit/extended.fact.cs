using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _RVAInit_extended_extended_
    {
        [ActiveIssue("2451")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _RVAInit_extended_extended_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\RVAInit\\extended\\extended.cmd");
        }
    }
}
