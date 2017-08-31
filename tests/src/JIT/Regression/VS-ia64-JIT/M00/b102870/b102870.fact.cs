using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _VS_ia64_JIT_M00_b102870_b102870_b102870_
    {
        [OuterLoop]
        [Fact]
        public void _VS_ia64_JIT_M00_b102870_b102870_b102870_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\VS-ia64-JIT\\M00\\b102870\\b102870\\b102870.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
