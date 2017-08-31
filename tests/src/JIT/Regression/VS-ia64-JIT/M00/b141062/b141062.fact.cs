using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _VS_ia64_JIT_M00_b141062_b141062_b141062_
    {
        [OuterLoop]
        [Fact]
        public void _VS_ia64_JIT_M00_b141062_b141062_b141062_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\VS-ia64-JIT\\M00\\b141062\\b141062\\b141062.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
