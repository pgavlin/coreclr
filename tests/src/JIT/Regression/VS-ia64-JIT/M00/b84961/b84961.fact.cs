using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _VS_ia64_JIT_M00_b84961_b84961_b84961_
    {
        [OuterLoop]
        [Fact]
        public void _VS_ia64_JIT_M00_b84961_b84961_b84961_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\VS-ia64-JIT\\M00\\b84961\\b84961\\b84961.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
