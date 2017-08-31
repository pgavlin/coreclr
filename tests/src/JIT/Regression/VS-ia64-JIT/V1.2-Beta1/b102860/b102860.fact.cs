using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _VS_ia64_JIT_V1_2_Beta1_b102860_b102860_b102860_
    {
        [OuterLoop]
        [Fact]
        public void _VS_ia64_JIT_V1_2_Beta1_b102860_b102860_b102860_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\VS-ia64-JIT\\V1.2-Beta1\\b102860\\b102860\\b102860.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
