using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_V1_M09_5_PDC_b32374_b32374_b32374_
    {
        [ActiveIssue("needs triage")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_M09_5_PDC_b32374_b32374_b32374_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-M09.5-PDC\\b32374\\b32374\\b32374.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
