using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _VS_ia64_JIT_V2_0_Beta2_b410474_b410474_b410474_
    {
        [ActiveIssue("2451")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _VS_ia64_JIT_V2_0_Beta2_b410474_b410474_b410474_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\VS-ia64-JIT\\V2.0-Beta2\\b410474\\b410474\\b410474.cmd");
        }
    }
}
