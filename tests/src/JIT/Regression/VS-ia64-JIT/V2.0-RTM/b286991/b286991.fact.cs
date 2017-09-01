using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _VS_ia64_JIT_V2_0_RTM_b286991_b286991_b286991_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _VS_ia64_JIT_V2_0_RTM_b286991_b286991_b286991_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\VS-ia64-JIT\\V2.0-RTM\\b286991\\b286991\\b286991.cmd");
        }
    }
}
