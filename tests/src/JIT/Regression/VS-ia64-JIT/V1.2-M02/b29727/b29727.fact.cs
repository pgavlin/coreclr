using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _VS_ia64_JIT_V1_2_M02_b29727_b29727_b29727_
    {
        [OuterLoop]
        [Fact]
        public void _VS_ia64_JIT_V1_2_M02_b29727_b29727_b29727_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\VS-ia64-JIT\\V1.2-M02\\b29727\\b29727\\b29727.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
