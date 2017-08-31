using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_V1_2_M01_b08046_b08046_b08046_
    {
        [ActiveIssue("4849")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_2_M01_b08046_b08046_b08046_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1.2-M01\\b08046\\b08046\\b08046.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
