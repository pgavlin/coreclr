using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _VS_ia64_JIT_M00_b80738_b80738_b80738_
    {
        [OuterLoop]
        [Fact]
        public void _VS_ia64_JIT_M00_b80738_b80738_b80738_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\VS-ia64-JIT\\M00\\b80738\\b80738\\b80738.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
