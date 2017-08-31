using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _VS_ia64_JIT_V1_2_M02_b12011_b12011_b12011_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [Fact]
        public void _VS_ia64_JIT_V1_2_M02_b12011_b12011_b12011_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\VS-ia64-JIT\\V1.2-M02\\b12011\\b12011\\b12011.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
