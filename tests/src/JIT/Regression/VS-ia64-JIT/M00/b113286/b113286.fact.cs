using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _VS_ia64_JIT_M00_b113286_b113286_b113286_
    {
        [OuterLoop]
        [Fact]
        public void _VS_ia64_JIT_M00_b113286_b113286_b113286_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\VS-ia64-JIT\\M00\\b113286\\b113286\\b113286.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
