using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_JIT_V1_M11_Beta1_b37598_b37598_b37598_
    {
        [ActiveIssue("needs triage")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_M11_Beta1_b37598_b37598_b37598_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-M11-Beta1\\b37598\\b37598\\b37598.cmd");
        }
    }
}
