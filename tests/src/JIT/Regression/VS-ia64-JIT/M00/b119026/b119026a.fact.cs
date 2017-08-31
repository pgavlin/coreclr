using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _VS_ia64_JIT_M00_b119026_b119026a_b119026a_
    {
        [OuterLoop]
        [Fact]
        public void _VS_ia64_JIT_M00_b119026_b119026a_b119026a_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\VS-ia64-JIT\\M00\\b119026\\b119026a\\b119026a.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
