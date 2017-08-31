using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _VS_ia64_JIT_M00_b79852_b79852_b79852_
    {
        [OuterLoop]
        [Fact]
        public void _VS_ia64_JIT_M00_b79852_b79852_b79852_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\VS-ia64-JIT\\M00\\b79852\\b79852\\b79852.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
