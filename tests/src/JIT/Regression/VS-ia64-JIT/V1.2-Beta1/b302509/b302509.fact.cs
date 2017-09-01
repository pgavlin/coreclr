using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _VS_ia64_JIT_V1_2_Beta1_b302509_b302509_b302509_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _VS_ia64_JIT_V1_2_Beta1_b302509_b302509_b302509_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\VS-ia64-JIT\\V1.2-Beta1\\b302509\\b302509\\b302509.cmd");
        }
    }
}
