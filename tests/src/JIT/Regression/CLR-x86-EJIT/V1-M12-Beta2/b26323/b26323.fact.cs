using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_EJIT_V1_M12_Beta2_b26323_b26323_b26323_
    {
        [ActiveIssue("needs triage")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _CLR_x86_EJIT_V1_M12_Beta2_b26323_b26323_b26323_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-EJIT\\V1-M12-Beta2\\b26323\\b26323\\b26323.cmd");
        }
    }
}
