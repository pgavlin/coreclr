using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _clr_x64_JIT_v2_1_b173569_b173569_b173569_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _clr_x64_JIT_v2_1_b173569_b173569_b173569_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\clr-x64-JIT\\v2.1\\b173569\\b173569\\b173569.cmd");
        }
    }
}
