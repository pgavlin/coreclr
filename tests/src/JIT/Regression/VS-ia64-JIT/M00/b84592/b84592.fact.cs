using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _VS_ia64_JIT_M00_b84592_b84592_b84592_
    {
        [OuterLoop]
        [Fact]
        public void _VS_ia64_JIT_M00_b84592_b84592_b84592_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\VS-ia64-JIT\\M00\\b84592\\b84592\\b84592.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
