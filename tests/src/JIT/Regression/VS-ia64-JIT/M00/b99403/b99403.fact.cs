using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _VS_ia64_JIT_M00_b99403_b99403_b99403_
    {
        [OuterLoop]
        [Fact]
        public void _VS_ia64_JIT_M00_b99403_b99403_b99403_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\VS-ia64-JIT\\M00\\b99403\\b99403\\b99403.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
