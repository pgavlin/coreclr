using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_JIT_V1_M12_Beta2_b31745_b31745_b31745_
    {
        [ActiveIssue("needs triage")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_M12_Beta2_b31745_b31745_b31745_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-M12-Beta2\\b31745\\b31745\\b31745.cmd");
        }
    }
}
